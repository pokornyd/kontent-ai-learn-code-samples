// Create a delivery client using the builder pattern
using var clientContainer = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithEnvironmentId("your-environment-id")
        .UseProductionApi()
        .Build())
    .Build();

// Get the client from the container
var client = clientContainer.Client;

// Gets a specific taxonomy group
var result = await client.GetTaxonomy("personas").ExecuteAsync();

if (result.IsSuccess)
{
    ITaxonomyGroup taxonomy = result.Value;
}