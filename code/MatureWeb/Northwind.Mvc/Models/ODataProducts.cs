﻿using Northwind.EntityModels; // To use Product.

namespace Northwind.Mvc.Models;

public class ODataProducts
{
  public Product[]? Value { get; set; }
}
