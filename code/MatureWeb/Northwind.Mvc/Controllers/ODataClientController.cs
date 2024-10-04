using Microsoft.AspNetCore.Mvc;
using Northwind.EntityModels;
using Northwind.Mvc.Models;

namespace Northwind.Mvc.Controllers;

public class ODataClientController : Controller
{
  protected readonly ILogger<ODataClientController> _logger;
  protected readonly IHttpClientFactory _httpClientFactory;

  public ODataClientController(
    ILogger<ODataClientController> logger,
    IHttpClientFactory httpClientFactory)
  {
    _logger = logger;
    _httpClientFactory = httpClientFactory;
  }

  public async Task<IActionResult> Index(string startsWith = "Cha")
  {
    IEnumerable<Product>? model = Enumerable.Empty<Product>();
    try
    {
      HttpClient client = _httpClientFactory.CreateClient(
        name: "Northwind.OData");

      HttpRequestMessage request = new(
        method: HttpMethod.Get, requestUri:
        "catalog/products/?$filter=startswith(ProductName," +
        $"'{startsWith}')&$select=ProductId,ProductName,UnitPrice");

      HttpResponseMessage response = await client.SendAsync(request);

      ViewData["startsWith"] = startsWith;
      model = (await response.Content
        .ReadFromJsonAsync<ODataProducts>())?.Value;
    }
    catch (Exception ex)
    {
      _logger.LogWarning(
        $"Northwind.OData exception: {ex.Message}");
    }

    return View(model);
  }
}
