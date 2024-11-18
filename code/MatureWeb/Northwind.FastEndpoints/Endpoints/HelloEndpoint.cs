using FastEndpoints; // To use Endpoint<TRequest, TResponse>.

namespace Northwind.FastEndpoints.Endpoints;

public class HelloEndpoint : Endpoint<HelloRequest, HelloResponse>
{
  public override void Configure()
  {
    // Automatically supports query strings, for example:
    // GET /hello?Name=Bob&Age=50

    // Explicitly specify route parameters:
    // GET /hello/Bob/50

    Verbs(Http.GET);
    Routes("/hello", "/hello/{Name}/{Age}");

    AllowAnonymous();
  }

  public override async Task HandleAsync(HelloRequest req, CancellationToken ct)
  {
    HelloResponse response = new($"Hello, {req.Name
      }. You're looking great for {req.Age}!");

    await SendAsync(response, cancellation: ct);
  }
}

public record HelloRequest(string Name, int Age);

public record HelloResponse(string Message);
