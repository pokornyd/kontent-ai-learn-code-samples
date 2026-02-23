// Create a delivery client using the builder pattern
using var clientContainer = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithEnvironmentId("your-environment-id")
        .UseProductionApi()
        .Build())
    .Build();

// Get the client from the container
var client = clientContainer.Client;

// Gets 3 languages
var result = await client.GetLanguages()
    .Limit(3)
    .ExecuteAsync();

if (result.IsSuccess)
{
    IReadOnlyList<ILanguage> languages = result.Value.Languages;
}