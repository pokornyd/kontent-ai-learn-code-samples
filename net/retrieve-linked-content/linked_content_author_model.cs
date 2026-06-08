#nullable enable

using System.Text.Json.Serialization;
using Kontent.Ai.Delivery.Attributes;
using Kontent.Ai.Delivery.ContentItems.RichText;

// Tip: Generate models via https://github.com/kontent-ai/model-generator-net

namespace KontentAiModels;

// Identifies this record as the Author content type for the SDK's type resolution
[ContentTypeCodename("author")]
public partial record Author
{
    public const string NameCodename = "name";
    public const string BioCodename = "bio";

    public const string ContentTypeCodename = "author";

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("bio")]
    public RichTextContent? Bio { get; init; }
}
