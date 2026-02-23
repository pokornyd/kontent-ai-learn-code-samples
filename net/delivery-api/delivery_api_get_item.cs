// Create a delivery client using the builder pattern
using var clientContainer = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithEnvironmentId("your-environment-id")
        .UseProductionApi()
        .Build())
    .Build();

// Get the client from the container
var client = clientContainer.Client;

// Gets a strongly typed article
// Tip: Create strongly typed models via https://github.com/kontent-ai/model-generator-net
var result = await client.GetItem<Article>("my_article").ExecuteAsync();

if (result.IsSuccess)
{
    Article item = result.Value.Elements;
}