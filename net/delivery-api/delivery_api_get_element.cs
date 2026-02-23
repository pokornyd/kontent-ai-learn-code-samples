// Create a delivery client using the builder pattern
using var clientContainer = DeliveryClientBuilder
      .WithOptions(builder => builder
            .WithEnvironmentId("your-environment-id")
            .UseProductionApi()
            .Build())
      .Build();

// Get the client from the container
var client = clientContainer.Client;

// Gets the model of a specific element within a specific content type
var result = await client.GetContentElement("article", "title").ExecuteAsync();

if (result.IsSuccess)
{
      IContentElement element = result.Value;
      Console.WriteLine($"Name: {element.Name}");
      Console.WriteLine($"Type: {element.Type}");
      Console.WriteLine($"Codename: {element.Codename}");
}