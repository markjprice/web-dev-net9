using Northwind.EntityModels; // To use Supplier.

namespace Northwind.Mvc.Models;

public record HomeSuppliersViewModel(
  IEnumerable<Supplier>? Suppliers);
