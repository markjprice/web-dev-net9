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
  public IActionResult Get(string version = "1")
  {
    Console.WriteLine($"*** ProductsController version {version}.");
    return Ok(_db.Products);
  }

  [EnableQuery]
  public IActionResult Get(int key, string version = "1")
  {
    Console.WriteLine($"*** ProductsController version {version}.");

    IQueryable<Product> products = _db.Products.Where(
      product => product.ProductId == key);

    Product? p = products.FirstOrDefault();

    if ((products is null) || (p is null))
    {
      return NotFound($"Product with id {key} not found.");
    }

    if (version == "2")
    {
      p.ProductName += " version 2.0";
    }

    return Ok(p);
  }

  public IActionResult Post([FromBody] Product product)
  {
    _db.Products.Add(product);
    _db.SaveChanges();
    return Created(product);
  }

  public IActionResult Put(int key, [FromBody] Product product)
  {
    Product? productToUpdate = _db.Products.Find(key);

    if (productToUpdate is null)
    {
      return NotFound($"Product with id {key} not found.");
    }

    productToUpdate.ProductName = product.ProductName;
    productToUpdate.SupplierId = product.SupplierId;
    productToUpdate.CategoryId = product.CategoryId;
    productToUpdate.QuantityPerUnit = product.QuantityPerUnit;
    productToUpdate.UnitPrice = product.UnitPrice;
    productToUpdate.UnitsInStock = product.UnitsInStock;
    productToUpdate.UnitsOnOrder = product.UnitsOnOrder;
    productToUpdate.ReorderLevel = product.ReorderLevel;
    productToUpdate.Discontinued = product.Discontinued;

    _db.SaveChanges();
    return Updated(product);
  }

  public IActionResult Delete(int key)
  {
    Product? productToDelete = _db.Products.Find(key);

    if (productToDelete is null)
    {
      return NotFound($"Product with id {key} not found.");
    }

    _db.Products.Remove(productToDelete);
    _db.SaveChanges();

    return NoContent();
  }
}
