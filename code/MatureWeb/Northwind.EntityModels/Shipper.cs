using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Northwind.EntityModels;

public partial class Shipper
{
  [Key]
  [Display(Name = "Shipper ID")]
  public int ShipperId { get; set; }

  [StringLength(40)]
  [Display(Name = "Company Name")]
  public string CompanyName { get; set; } = null!;

  [StringLength(24)]
  public string? Phone { get; set; }

  [InverseProperty("ShipViaNavigation")]
  public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
