// Create a delivery client for previewing content
using var clientContainer = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithEnvironmentId("your-environment-id")
        .UsePreviewApi("your-preview-api-key")
        .Build())
    .Build();

// Get the client from the container
var client = clientContainer.Client;

// Generate strongly typed models via https://github.com/kontent-ai/model-generator-net
var result = await client.GetItem<Article>("my_article").ExecuteAsync();

if (result.IsSuccess)
{
    Article item = result.Value.Elements;
}