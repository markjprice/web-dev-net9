using Northwind.EntityModels; // To use Supplier.

namespace Northwind.Mvc.Models;

public record HomeSupplierViewModel(
  int EntitiesAffected, Supplier? Supplier);
