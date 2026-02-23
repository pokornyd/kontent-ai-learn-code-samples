// Create a delivery client using the builder pattern
using var clientContainer = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithEnvironmentId("your-environment-id")
        .UseProductionApi()
        .Build())
    .Build();

// Get the client from the container
var client = clientContainer.Client;

// Gets a specific content type
var result = await client.GetType("article").ExecuteAsync();

if (result.IsSuccess)
{
    IContentType type = result.Value;
}