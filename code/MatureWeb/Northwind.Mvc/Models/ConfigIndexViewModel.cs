namespace Northwind.Mvc.Models;

public record ConfigIndexViewModel(
  IEnumerable<string?> Providers,
  IDictionary<string, string?> Settings,
  string OutputCachingLoggingLevel,
  string IdentityConnectionString,
  NorthwindOptions Options);
