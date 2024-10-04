using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Northwind.EntityModels; // To use Customer.

namespace Northwind.Mvc.Controllers;

public class CorsController : Controller
{
  private readonly ILogger<CorsController> _logger;
  private readonly IHttpClientFactory _httpClientFactory;

  public CorsController(ILogger<CorsController> logger,
    IHttpClientFactory httpClientFactory)
  {
    _logger = logger;
    _httpClientFactory = httpClientFactory;
  }

  public IActionResult JavaScript()
  {
    return View();
  }

  public async Task<IActionResult> Net(string? country)
  {
    HttpClient client = _httpClientFactory.CreateClient(
      name: "Northwind.WebApi");

    HttpRequestMessage request = new(
      method: HttpMethod.Get, requestUri: $"api/customers/?country={country}");

    HttpResponseMessage response = await client.SendAsync(request);

    IEnumerable<Customer>? model = await response.Content
      .ReadFromJsonAsync<IEnumerable<Customer>>();

    ViewData["baseaddress"] = client.BaseAddress;

    return View(model);
  }
}
