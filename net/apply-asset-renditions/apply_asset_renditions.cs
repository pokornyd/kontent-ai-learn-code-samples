// Create a delivery client using the builder pattern
using var clientContainer = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithEnvironmentId("your-environment-id")
        .UseProductionApi()
        .Build())
    .Build();

// Get the client from the container
var client = clientContainer.Client;

// Retrieve a strongly-typed content item
var response = await client.GetItem<Article>("my_article").ExecuteAsync();

if (response.IsSuccess)
{
    // Gets the image from an asset element named Hero Image
    var imageWithRendition = response.Value.Elements.HeroImage
        .SingleOrDefault(x => x.Name == "construction-insurance-header.jpg");

    if (imageWithRendition is not null)
    {
        // Gets the asset rendition query from the image
        var renditionQuery = imageWithRendition.Renditions["default"].Query;

        // Combines the original image URL with the asset rendition query, if the image specifies a query
        var assetUrl = $"{imageWithRendition.Url}?{renditionQuery}";
    }
}