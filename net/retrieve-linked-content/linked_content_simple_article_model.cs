#nullable enable

using System.Collections.Generic;
using System.Text.Json.Serialization;
using Kontent.Ai.Delivery.Abstractions;
using Kontent.Ai.Delivery.Attributes;
using Kontent.Ai.Delivery.ContentItems.RichText;

// Tip: Generate models via https://github.com/kontent-ai/model-generator-net

namespace KontentAiModels;

[ContentTypeCodename("simple_article")]
public partial record SimpleArticle
{
    public const string TitleCodename = "title";
    public const string BodyCodename = "body";
    public const string AuthorCodename = "author";

    public const string ContentTypeCodename = "simple_article";

    [JsonPropertyName("title")]
    public string? Title { get; init; }
    [JsonPropertyName("body")]
    public RichTextContent? Body { get; init; }
    [JsonPropertyName("author")]
    public IEnumerable<IEmbeddedContent>? Author { get; init; }
}
