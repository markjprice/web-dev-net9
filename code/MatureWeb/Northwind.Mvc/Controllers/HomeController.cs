using System.Diagnostics; // To use Activity.
using Microsoft.AspNetCore.Mvc; // To use Controller, IActionResult.
using Northwind.Mvc.Models; // To use ErrorViewModel.
using Northwind.EntityModels; // To use NorthwindContext.
using Microsoft.EntityFrameworkCore; // To use Include method.
using Microsoft.AspNetCore.Authorization; // To use [Authorize].
using Microsoft.Extensions.Caching.Memory; // To use IMemoryCache.
using Microsoft.Extensions.Caching.Distributed; // To use IDistributedCache.
using System.Text.Json; // To use JsonSerializer.

namespace Northwind.Mvc.Controllers;

public class HomeController : Controller
{
  private readonly ILogger<HomeController> _logger;
  private readonly NorthwindContext _db;

  private readonly IMemoryCache _memoryCache;
  private const string ProductKey = "PROD";

  private readonly IDistributedCache _distributedCache;
  private const string CategoriesKey = "CATEGORIES";

  private readonly IHttpClientFactory _clientFactory;

  public HomeController(ILogger<HomeController> logger,
    NorthwindContext db, IMemoryCache memoryCache,
    IDistributedCache distributedCache,
    IHttpClientFactory httpClientFactory)
  {
    _logger = logger;
    _db = db;
    _memoryCache = memoryCache;
    _distributedCache = distributedCache;
    _clientFactory = httpClientFactory;
  }

  private async Task<List<Category>> GetCategoriesFromDatabaseAsync()
  {
    List<Category> cachedValue = await _db.Categories.ToListAsync();

    DistributedCacheEntryOptions cacheEntryOptions = new()
    {
      // Allow readers to reset the cache entry's lifetime.
      SlidingExpiration = TimeSpan.FromMinutes(1),

      // Set an absolute expiration time for the cache entry.
      AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(20),
    };

    byte[]? cachedValueBytes =
      JsonSerializer.SerializeToUtf8Bytes(cachedValue);

    await _distributedCache.SetAsync(CategoriesKey,
      cachedValueBytes, cacheEntryOptions);

    return cachedValue;
  }

  [ResponseCache(Duration = DurationInSeconds.TenSeconds,
    Location = ResponseCacheLocation.Any)]
  public async Task<IActionResult> Index()
  {
    /*
    _logger.LogError("This is a serious error (not really!)");
    _logger.LogWarning("This is your first warning!");
    _logger.LogWarning("Second warning!");
    _logger.LogInformation("I am in the Index method of the HomeController.");
    */

    // Try to get the cached value.
    List<Category>? cachedValue = null;

    byte[]? cachedValueBytes = 
      await _distributedCache.GetAsync(CategoriesKey);

    if (cachedValueBytes is null)
    {
      cachedValue = await GetCategoriesFromDatabaseAsync();
    }
    else
    {
      cachedValue = JsonSerializer
        .Deserialize<List<Category>>(cachedValueBytes);

      if (cachedValue is null)
      {
        cachedValue = await GetCategoriesFromDatabaseAsync();
      }
    }

    HomeIndexViewModel model = new
    (
      VisitorCount: Random.Shared.Next(1, 1001),
      Categories: cachedValue ?? new List<Category>(),
      Products: await _db.Products.ToListAsync()
    );

    return View(model); // Pass the model to the view.
  }

  [Route("private")]
  public async Task<IActionResult> Privacy()
  {
    // Construct a dictionary to store properties of a shipper.
    Dictionary<string, string>? keyValuePairs = null;

    // Find the shipper with ID of 1.
    Shipper? shipper1 = await _db.Shippers.FindAsync(1);

    if (shipper1 is not null)
    {
      keyValuePairs = new()
      {
        { "ShipperId", shipper1.ShipperId.ToString() },
        { "CompanyName", shipper1.CompanyName },
        { "Phone", shipper1.Phone ?? string.Empty }
      };
    }

    ViewData["shipper1"] = keyValuePairs;

    return View();
  }

  [ResponseCache(Duration = 0,
    Location = ResponseCacheLocation.None,
    NoStore = true)]
  public IActionResult Error()
  {
    return View(new ErrorViewModel
    {
      RequestId =
      Activity.Current?.Id ?? HttpContext.TraceIdentifier
    });
  }

  public async Task<IActionResult> ProductDetail(int? id,
    string alertstyle = "success")
  {
    ViewData["alertstyle"] = alertstyle;

    if (!id.HasValue)
    {
      return BadRequest("You must pass a product ID in the route, for example, /Home/ProductDetail/21");
    }

    // Try to get the cached product.
    if (!_memoryCache.TryGetValue($"{ProductKey}{id}",
      out Product? model))
    {
      // If the cached value is not found, get the value from the database.
      model = await _db.Products.Include(p => p.Category)
        .SingleOrDefaultAsync(p => p.ProductId == id);

      if (model is null)
      {
        return NotFound($"ProductId {id} not found.");
      }

      MemoryCacheEntryOptions cacheEntryOptions = new()
      {
        SlidingExpiration = TimeSpan.FromSeconds(5),
        Size = 1 // product
      };

      _memoryCache.Set($"{ProductKey}{id}", model, cacheEntryOptions);
    }

    MemoryCacheStatistics? stats = _memoryCache.GetCurrentStatistics();

    _logger.LogInformation($"Memory cache. Total hits: {stats?
      .TotalHits}. Estimated size: {stats?.CurrentEstimatedSize}.");

    return View(model); // Pass model to view and then return result.
  }

  // This action method will handle GET and other requests except POST.
  [Authorize(Roles = "Administrators")]
  public IActionResult ModelBinding()
  {
    return View(); // The page with a form to submit.
  }

  // This action method will handle POST requests.
  [HttpPost]
  public IActionResult ModelBinding(Thing thing)
  {
    HomeModelBindingViewModel model = new(
      Thing: thing, HasErrors: !ModelState.IsValid,
      ValidationErrors: ModelState.Values
        .SelectMany(state => state.Errors)
        .Select(error => error.ErrorMessage)
    );

    return View(model); // Show the model bound thing.
  }

  // GET: /home/suppliers
  public IActionResult Suppliers()
  {
    HomeSuppliersViewModel model = new(_db.Suppliers
      .OrderBy(c => c.Country)
      .ThenBy(c => c.CompanyName));

    return View(model);
  }

  // GET: /home/editsupplier/{id}
  public IActionResult EditSupplier(int? id)
  {
    Supplier? supplierInDb = _db.Suppliers.Find(id);

    HomeSupplierViewModel model = new(
      supplierInDb is null ? 0 : 1, supplierInDb);

    // Views\Home\EditSupplier.cshtml
    return View(model);
  }

  // POST: /home/editsupplier
  // Body: JSON Supplier
  // Updates an existing supplier.
  [HttpPost]
  [ValidateAntiForgeryToken]
  public IActionResult EditSupplier(Supplier supplier)
  {
    int affected = 0;

    if (ModelState.IsValid)
    {
      Supplier? supplierInDb = _db.Suppliers.Find(supplier.SupplierId);

      if (supplierInDb is not null)
      {
        supplierInDb.CompanyName = supplier.CompanyName;
        supplierInDb.Country = supplier.Country;
        supplierInDb.Phone = supplier.Phone;

        /*
        // Other properties not in the HTML form.
        supplierInDb.ContactName = supplier.ContactName;
        supplierInDb.ContactTitle = supplier.ContactTitle;
        supplierInDb.Address = supplier.Address;
        supplierInDb.City = supplier.City;
        supplierInDb.Region = supplier.Region;
        supplierInDb.PostalCode = supplier.PostalCode;
        supplierInDb.Fax = supplier.Fax;
        */

        affected = _db.SaveChanges();
      }
    }

    HomeSupplierViewModel model = new(
      affected, supplier);

    if (affected == 0) // Supplier was not updated.
    {
      // Views\Home\EditSupplier.cshtml
      return View(model);
    }
    else // Supplier was updated; show in table.
    {
      return RedirectToAction("Suppliers");
    }
  }

  // GET: /home/deletesupplier/{id}
  public IActionResult DeleteSupplier(int? id)
  {
    Supplier? supplierInDb = _db.Suppliers.Find(id);

    HomeSupplierViewModel model = new(
      supplierInDb is null ? 0 : 1, supplierInDb);

    // Views\Home\DeleteSupplier.cshtml
    return View(model);
  }

  // POST: /home/deletesupplier/{id}
  // Removes an existing supplier.
  [HttpPost("/home/deletesupplier/{id:int?}")]
  [ValidateAntiForgeryToken]
  // C# won't allow two methods with the same name and signature.
  public IActionResult DeleteSupplierX(int? id)
  {
    int affected = 0;

    Supplier? supplierInDb = _db.Suppliers.Find(id);

    if (supplierInDb is not null)
    {
      _db.Suppliers.Remove(supplierInDb);
      affected = _db.SaveChanges();
    }

    HomeSupplierViewModel model = new(
      affected, supplierInDb);

    if (affected == 0) // Supplier was not deleted.
    {
      // Views\Home\DeleteSupplier.cshtml
      return View(model);
    }
    else
    {
      return RedirectToAction("Suppliers");
    }
  }

  // GET: /home/addsupplier
  public IActionResult AddSupplier()
  {
    HomeSupplierViewModel model = new(
      0, new Supplier());

    // Views\Home\AddSupplier.cshtml
    return View(model);
  }

  // POST: /home/addsupplier
  // Body: JSON Supplier
  // Inserts a new supplier.
  [HttpPost]
  [ValidateAntiForgeryToken]
  public IActionResult AddSupplier(Supplier supplier)
  {
    int affected = 0;

    if (ModelState.IsValid)
    {
      _db.Suppliers.Add(supplier);
      affected = _db.SaveChanges();
    }

    HomeSupplierViewModel model = new(
      affected, supplier);

    if (affected == 0) // Supplier was not added.
    {
      // Views\Home\AddSupplier.cshtml
      return View(model);
    }
    else
    {
      return RedirectToAction("Suppliers");
    }
  }

  public IActionResult ProductsThatCostMoreThan(decimal? price)
  {
    if (!price.HasValue)
    {
      return BadRequest("You must pass a product price in the query string, for example, /Home/ProductsThatCostMoreThan?price=50");
    }

    IEnumerable<Product> model = _db.Products
      .Include(p => p.Category)
      .Include(p => p.Supplier)
      .Where(p => p.UnitPrice > price);

    if (!model.Any())
    {
      return NotFound(
        $"No products cost more than {price:C}.");
    }

    // Format currency using web server's culture.
    ViewData["MaxPrice"] = price.Value.ToString("C");

    // We can override the search path convention.
    return View("Views/Home/CostlyProducts.cshtml", model);
  }

  public IActionResult Orders(
    string? id = null, string? country = null)
  {
    // Start with a simplified initial model.
    IEnumerable<Order> model = _db.Orders
      .Include(order => order.Customer)
      .Include(order => order.OrderDetails);

    // Add filtering based on parameters.
    if (id is not null)
    {
      model = model.Where(order => order.Customer?.CustomerId == id);
    }
    else if (country is not null)
    {
      model = model.Where(order => order.Customer?.Country == country);
    }

    // Add ordering and make enumerable.
    model = model
      .OrderByDescending(order => order.OrderDetails
        .Sum(detail => detail.Quantity * detail.UnitPrice))
      .AsEnumerable();

    return View(model);
  }

  public IActionResult Shipper(Shipper shipper)
  {
    return View(shipper);
  }

  [HttpPost]
  [ValidateAntiForgeryToken]
  public IActionResult ProcessShipper(Shipper shipper)
  {
    return Json(shipper);
  }

  public async Task<IActionResult> Customers(string country)
  {
    string uri;

    if (string.IsNullOrEmpty(country))
    {
      ViewData["Title"] = "All Customers Worldwide";
      uri = "api/customers";
    }
    else
    {
      ViewData["Title"] = $"Customers in {country}";
      uri = $"api/customers/?country={country}";
    }

    HttpClient client = _clientFactory.CreateClient(
      name: "Northwind.WebApi");

    HttpRequestMessage request = new(
      method: HttpMethod.Get, requestUri: uri);

    HttpResponseMessage response = await client.SendAsync(request);

    IEnumerable<Customer>? model = await response.Content
      .ReadFromJsonAsync<IEnumerable<Customer>>();

    return View(model);
  }
}
