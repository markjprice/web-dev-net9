using Microsoft.AspNetCore.Mvc; // To use IActionResult.
using Microsoft.AspNetCore.OData.Query; // To use [EnableQuery].
using Microsoft.AspNetCore.OData.Routing.Controllers; // To use ODataController.
using Northwind.EntityModels; // To use NorthwindContext.

namespace Northwind.OData.Services.Controllers;

public class CustomersController : ODataController
{
  protected readonly NorthwindContext _db;

  public CustomersController(NorthwindContext db)
  {
    _db = db;
  }

  [EnableQuery]
  public IActionResult Get()
  {
    return Ok(_db.Customers);
  }

  [EnableQuery]
  public IActionResult Get(string key)
  {
    return Ok(_db.Customers.Where(
      customer => customer.CustomerId == key));
  }
}
