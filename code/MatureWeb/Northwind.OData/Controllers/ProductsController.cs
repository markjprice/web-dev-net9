using Microsoft.AspNetCore.Mvc; // To use IActionResult.
using Microsoft.AspNetCore.OData.Query; // To use [EnableQuery].
using Microsoft.AspNetCore.OData.Routing.Controllers; // ODataController
using Northwind.EntityModels; // To use NorthwindContext.

namespace Northwind.OData.Controllers;

public class ProductsController : ODataController
{
  protected readonly NorthwindContext _db;

  public ProductsController(NorthwindContext db)
  {
    _db = db;
  }

  [EnableQuery]
  public IActionResult Get()
  {
    return Ok(_db.Products);
  }

  [EnableQuery]
  public IActionResult Get(int key)
  {
    return Ok(_db.Products.Where(
      product => product.ProductId == key));
  }
}
