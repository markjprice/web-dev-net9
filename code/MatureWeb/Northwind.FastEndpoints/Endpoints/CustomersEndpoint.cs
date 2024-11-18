using FastEndpoints; // To use Endpoint<TRequest, TResponse>.
using Northwind.EntityModels; // To use Customer.

namespace Northwind.FastEndpoints.Endpoints;

public class CustomersEndpoint : Endpoint<CustomersRequest, Customer[]>
{
  private readonly NorthwindContext _db;

  public CustomersEndpoint(NorthwindContext db)
  {
    _db = db;
  }

  public override void Configure()
  {
    Verbs(Http.GET);
    Routes("/customers", "/customers/{Country}");
    AllowAnonymous();
  }

  public override async Task HandleAsync(
    CustomersRequest request, CancellationToken ct)
  {
    IQueryable<Customer> query = _db.Customers;

    if (!string.IsNullOrWhiteSpace(request.Country))
    {
      query = query.Where(customer => customer.Country == request.Country);
    }

    Customer[] response = query.ToArray();

    await SendAsync(response, cancellation: ct);
  }
}

public record CustomersRequest(string Country);
