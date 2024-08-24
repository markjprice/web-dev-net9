using Microsoft.AspNetCore.Mvc; // To use IActionResult.
using Microsoft.AspNetCore.OData.Query; // To use [EnableQuery].
using Microsoft.AspNetCore.OData.Routing.Controllers; // ODataController
using Northwind.EntityModels; // To use NorthwindContext.

namespace Northwind.OData.Controllers;

public class CategoriesController : ODataController
{
  protected readonly NorthwindContext _db;

  public CategoriesController(NorthwindContext db)
  {
    _db = db;
  }

  [EnableQuery]
  public IActionResult Get()
  {
    return Ok(_db.Categories);
  }

  [EnableQuery]
  public IActionResult Get(int key)
  {
    return Ok(_db.Categories.Where(
      category => category.CategoryId == key));
  }
}
