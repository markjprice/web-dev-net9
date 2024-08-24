using Microsoft.AspNetCore.Mvc; // To use IActionResult.
using Microsoft.AspNetCore.OData.Query; // To use [EnableQuery].
using Microsoft.AspNetCore.OData.Routing.Controllers; // ODataController
using Northwind.EntityModels; // To use NorthwindContext.

namespace Northwind.OData.Controllers;

public class SuppliersController : ODataController
{
  protected readonly NorthwindContext _db;

  public SuppliersController(NorthwindContext db)
  {
    _db = db;
  }

  [EnableQuery]
  public IActionResult Get()
  {
    return Ok(_db.Suppliers);
  }

  [EnableQuery]
  public IActionResult Get(int key)
  {
    return Ok(_db.Suppliers.Where(
      supplier => supplier.SupplierId == key));
  }
}
