// Create a delivery client using the builder pattern
using var clientContainer = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithEnvironmentId("your-environment-id")
        .UseProductionApi()
        .Build())
    .Build();

// Get the client from the container
var client = clientContainer.Client;

// Gets 3 articles ordered by the "Post date" element
// Note: When using source generation with [ContentTypeCodename("article")],
// the system.type filter is added automatically for GetItems<Article>()
var result = await client.GetItems<Article>()
    .OrderBy("elements.post_date", OrderingMode.Descending)
    .Limit(3)
    .ExecuteAsync();

if (result.IsSuccess)
{
    IReadOnlyList<IContentItem<Article>> items = result.Value.Items;
}