
using Newtonsoft.Json;
namespace DiscordBot.Models;
public partial class DocumentationData
    {
        [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        public string? Kind { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public Url? Url { get; set; }

        [JsonProperty("queries", NullValueHandling = NullValueHandling.Ignore)]
        public Queries? Queries { get; set; }

        [JsonProperty("context", NullValueHandling = NullValueHandling.Ignore)]
        public Context? Context { get; set; }

        [JsonProperty("searchInformation", NullValueHandling = NullValueHandling.Ignore)]
        public SearchInformation? SearchInformation { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public Items[]? Items { get; set; }
    }

    public class Context
    {
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string? Title { get; set; }
    }

    public class Items
    {
        // [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        // public Kind? Kind { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string? Title { get; set; }

        [JsonProperty("htmlTitle", NullValueHandling = NullValueHandling.Ignore)]
        public string? HtmlTitle { get; set; }

        [JsonProperty("link", NullValueHandling = NullValueHandling.Ignore)]
        public Uri? Link { get; set; }

        // [JsonProperty("displayLink", NullValueHandling = NullValueHandling.Ignore)]
        // public DisplayLink? DisplayLink { get; set; }

        [JsonProperty("snippet", NullValueHandling = NullValueHandling.Ignore)]
        public string? Snippet { get; set; }

        [JsonProperty("htmlSnippet", NullValueHandling = NullValueHandling.Ignore)]
        public string? HtmlSnippet { get; set; }

        [JsonProperty("cacheId", NullValueHandling = NullValueHandling.Ignore)]
        public string? CacheId { get; set; }

        [JsonProperty("formattedUrl", NullValueHandling = NullValueHandling.Ignore)]
        public Uri? FormattedUrl { get; set; }

        [JsonProperty("htmlFormattedUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string? HtmlFormattedUrl { get; set; }

        [JsonProperty("pagemap", NullValueHandling = NullValueHandling.Ignore)]
        public Pagemap? Pagemap { get; set; }
    }

    public partial class Pagemap
    {
        [JsonProperty("cse_thumbnail", NullValueHandling = NullValueHandling.Ignore)]
        public CseThumbnail[]? CseThumbnail { get; set; }

        [JsonProperty("organization", NullValueHandling = NullValueHandling.Ignore)]
        public Organization[]? Organization { get; set; }

        [JsonProperty("metatags", NullValueHandling = NullValueHandling.Ignore)]
        public Metatag[]? Metatags { get; set; }

        [JsonProperty("cse_image", NullValueHandling = NullValueHandling.Ignore)]
        public CseImage[]? CseImage { get; set; }

        [JsonProperty("listitem", NullValueHandling = NullValueHandling.Ignore)]
        public Listitem[]? Listitem { get; set; }
    }

    public partial class CseImage
    {
        [JsonProperty("src", NullValueHandling = NullValueHandling.Ignore)]
        public Uri? Src { get; set; }
    }

    public partial class CseThumbnail
    {
        [JsonProperty("src", NullValueHandling = NullValueHandling.Ignore)]
        public Uri? Src { get; set; }

        // [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        // [JsonConverter(typeof(PurpleParseStringConverter))]
        // public long? Width { get; set; }
        //
        // [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        // [JsonConverter(typeof(PurpleParseStringConverter))]
      //  public long? Height { get; set; }
    }

    public partial class Listitem
    {
        [JsonProperty("item", NullValueHandling = NullValueHandling.Ignore)]
        public string Item { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        // [JsonProperty("position", NullValueHandling = NullValueHandling.Ignore)]
        // [JsonConverter(typeof(PurpleParseStringConverter))]
       // public long? Position { get; set; }
    }

    public partial class Metatag
    {
        [JsonProperty("schema", NullValueHandling = NullValueHandling.Ignore)]
        public string Schema { get; set; }

        [JsonProperty("og:image", NullValueHandling = NullValueHandling.Ignore)]
        public string OgImage { get; set; }

        // [JsonProperty("twitter:card", NullValueHandling = NullValueHandling.Ignore)]
        // public TwitterCard? TwitterCard { get; set; }

        [JsonProperty("ms.technology", NullValueHandling = NullValueHandling.Ignore)]
        public string MsTechnology { get; set; }

        [JsonProperty("ms.author", NullValueHandling = NullValueHandling.Ignore)]
        public string MsAuthor { get; set; }

        [JsonProperty("ms.topic", NullValueHandling = NullValueHandling.Ignore)]
        public string MsTopic { get; set; }

        [JsonProperty("page_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PageType { get; set; }

        [JsonProperty("ms.devlang", NullValueHandling = NullValueHandling.Ignore)]
        public string MsDevlang { get; set; }
        //
        // [JsonProperty("document_id", NullValueHandling = NullValueHandling.Ignore)]
        // public Guid? DocumentId { get; set; }

        // [JsonProperty("locale", NullValueHandling = NullValueHandling.Ignore)]
        // public Locale? Locale { get; set; }
        //
        // [JsonProperty("og:description", NullValueHandling = NullValueHandling.Ignore)]
        // public string OgDescription { get; set; }
        //
        // [JsonProperty("ms.date", NullValueHandling = NullValueHandling.Ignore)]
        // public string MsDate { get; set; }
        //
        // [JsonProperty("recommendations", NullValueHandling = NullValueHandling.Ignore)]
        // [JsonConverter(typeof(FluffyParseStringConverter))]
        // public bool? Recommendations { get; set; }
        //
        // [JsonProperty("depot_name", NullValueHandling = NullValueHandling.Ignore)]
        // public DepotName? DepotName { get; set; }
        //
        // [JsonProperty("word_count", NullValueHandling = NullValueHandling.Ignore)]
        // [JsonConverter(typeof(PurpleParseStringConverter))]
        // public long? WordCount { get; set; }
        //
        // [JsonProperty("twitter:site", NullValueHandling = NullValueHandling.Ignore)]
        // public TwitterSite? TwitterSite { get; set; }

        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        // [JsonProperty("apiplatform", NullValueHandling = NullValueHandling.Ignore)]
        // public Apiplatform? Apiplatform { get; set; }

        [JsonProperty("original_content_git_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri OriginalContentGitUrl { get; set; }

        [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
        public string Scope { get; set; }

        [JsonProperty("ms.prod", NullValueHandling = NullValueHandling.Ignore)]
        public string MsProd { get; set; }

        [JsonProperty("pdf_url_template", NullValueHandling = NullValueHandling.Ignore)]
        public string PdfUrlTemplate { get; set; }

        // [JsonProperty("og:type", NullValueHandling = NullValueHandling.Ignore)]
        // public OgType? OgType { get; set; }

        [JsonProperty("og:image:alt", NullValueHandling = NullValueHandling.Ignore)]
        public string OgImageAlt { get; set; }

        // [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
        // public Author? Author { get; set; }

        [JsonProperty("og:title", NullValueHandling = NullValueHandling.Ignore)]
        public string OgTitle { get; set; }

        [JsonProperty("search.mshattr.devlang", NullValueHandling = NullValueHandling.Ignore)]
        public string SearchMshattrDevlang { get; set; }

        // [JsonProperty("color-scheme", NullValueHandling = NullValueHandling.Ignore)]
        // public ColorScheme? ColorScheme { get; set; }

        [JsonProperty("site_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SiteName { get; set; }

        // [JsonProperty("ms.assetid", NullValueHandling = NullValueHandling.Ignore)]
        // public Guid? MsAssetid { get; set; }

        // [JsonProperty("viewport", NullValueHandling = NullValueHandling.Ignore)]
        // public Viewport? Viewport { get; set; }
        //
        // [JsonProperty("breadcrumb_path", NullValueHandling = NullValueHandling.Ignore)]
        // public BreadcrumbPath? BreadcrumbPath { get; set; }

        // [JsonProperty("document_version_independent_id", NullValueHandling = NullValueHandling.Ignore)]
        // public Guid? DocumentVersionIndependentId { get; set; }

        [JsonProperty("og:url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri OgUrl { get; set; }

        [JsonProperty("uhfheaderid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uhfheaderid { get; set; }

        [JsonProperty("toc_rel", NullValueHandling = NullValueHandling.Ignore)]
        public string TocRel { get; set; }

        [JsonProperty("gitcommit", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Gitcommit { get; set; }

        // [JsonProperty("show_latex", NullValueHandling = NullValueHandling.Ignore)]
        // [JsonConverter(typeof(FluffyParseStringConverter))]
        // public bool? ShowLatex { get; set; }

        [JsonProperty("apilocation", NullValueHandling = NullValueHandling.Ignore)]
        public string Apilocation { get; set; }

        [JsonProperty("apitype", NullValueHandling = NullValueHandling.Ignore)]
        public string Apitype { get; set; }

        [JsonProperty("apiname", NullValueHandling = NullValueHandling.Ignore)]
        public string Apiname { get; set; }

        [JsonProperty("monikers", NullValueHandling = NullValueHandling.Ignore)]
        public string Monikers { get; set; }

        [JsonProperty("ms.custom", NullValueHandling = NullValueHandling.Ignore)]
        public string MsCustom { get; set; }
    }

    public partial class Organization
    {
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Url { get; set; }
    }

    public partial class Queries
    {
        [JsonProperty("request", NullValueHandling = NullValueHandling.Ignore)]
        public NextPage[] Request { get; set; }
    
        [JsonProperty("nextPage", NullValueHandling = NullValueHandling.Ignore)]
        public NextPage[] NextPage { get; set; }
    }

    public partial class NextPage
    {
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        // [JsonProperty("totalResults", NullValueHandling = NullValueHandling.Ignore)]
        // [JsonConverter(typeof(PurpleParseStringConverter))]
        // public long? TotalResults { get; set; }

        [JsonProperty("searchTerms", NullValueHandling = NullValueHandling.Ignore)]
        public string SearchTerms { get; set; }

        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public long? Count { get; set; }

        [JsonProperty("startIndex", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartIndex { get; set; }

        [JsonProperty("inputEncoding", NullValueHandling = NullValueHandling.Ignore)]
        public string InputEncoding { get; set; }

        [JsonProperty("outputEncoding", NullValueHandling = NullValueHandling.Ignore)]
        public string OutputEncoding { get; set; }

        [JsonProperty("safe", NullValueHandling = NullValueHandling.Ignore)]
        public string Safe { get; set; }

        [JsonProperty("cx", NullValueHandling = NullValueHandling.Ignore)]
        public string Cx { get; set; }
    }

    public partial class SearchInformation
    {
        [JsonProperty("searchTime", NullValueHandling = NullValueHandling.Ignore)]
        public double? SearchTime { get; set; }

        [JsonProperty("formattedSearchTime", NullValueHandling = NullValueHandling.Ignore)]
        public string FormattedSearchTime { get; set; }

        // [JsonProperty("totalResults", NullValueHandling = NullValueHandling.Ignore)]
        // [JsonConverter(typeof(PurpleParseStringConverter))]
        // public long? TotalResults { get; set; }

        [JsonProperty("formattedTotalResults", NullValueHandling = NullValueHandling.Ignore)]
        public string FormattedTotalResults { get; set; }
    }

    public partial class Url
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("template", NullValueHandling = NullValueHandling.Ignore)]
        public string Template { get; set; }
    }

    // public enum DisplayLink { DocsMicrosoftCom };
    //
    // public enum Kind { CustomsearchResult };
    //
    // public enum Apiplatform { Dotnet };
    //
    // public enum Author { BillWagner, DotnetBot, KrzysztofCwalina };
    //
    // public enum BreadcrumbPath { DotnetBreadcrumbTocJson };
    //
    // public enum ColorScheme { LightDark };
    //
    // public enum DepotName { VsCoreDocs, VsDotnetApiDocs };
    //
    // public enum Locale { EnUs };
    //
    // public enum OgType { Website };
    //
    // public enum TwitterCard { Summary };
    //
    // public enum TwitterSite { Docsmsft };
    //
    // public enum Viewport { WidthDeviceWidthInitialScale10 };

    public partial class DocumentationData
    {
        public static DocumentationData FromJson(string json) => JsonConvert.DeserializeObject<DocumentationData>(json, Converter.Settings);
    }
// internal class DisplayLinkConverter : JsonConverter
//     {
//         public override bool CanConvert(Type t) => t == typeof(DisplayLink) || t == typeof(DisplayLink?);
//
//         public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//         {
//             if (reader.TokenType == JsonToken.Null) return null;
//             var value = serializer.Deserialize<string>(reader);
//             if (value == "docs.microsoft.com")
//             {
//                 return DisplayLink.DocsMicrosoftCom;
//             }
//             throw new Exception("Cannot unmarshal type DisplayLink");
//         }
//
//         public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//         {
//             if (untypedValue == null)
//             {
//                 serializer.Serialize(writer, null);
//                 return;
//             }
//             var value = (DisplayLink)untypedValue;
//             if (value == DisplayLink.DocsMicrosoftCom)
//             {
//                 serializer.Serialize(writer, "docs.microsoft.com");
//                 return;
//             }
//             throw new Exception("Cannot marshal type DisplayLink");
//         }
//
//         public static readonly DisplayLinkConverter Singleton = new DisplayLinkConverter();
//     }
//
//     internal class KindConverter : JsonConverter
//     {
//         public override bool CanConvert(Type t) => t == typeof(Kind) || t == typeof(Kind?);
//
//         public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//         {
//             if (reader.TokenType == JsonToken.Null) return null;
//             var value = serializer.Deserialize<string>(reader);
//             if (value == "customsearch#result")
//             {
//                 return Kind.CustomsearchResult;
//             }
//             throw new Exception("Cannot unmarshal type Kind");
//         }
//
//         public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//         {
//             if (untypedValue == null)
//             {
//                 serializer.Serialize(writer, null);
//                 return;
//             }
//             var value = (Kind)untypedValue;
//             if (value == Kind.CustomsearchResult)
//             {
//                 serializer.Serialize(writer, "customsearch#result");
//                 return;
//             }
//             throw new Exception("Cannot marshal type Kind");
//         }
//
//         public static readonly KindConverter Singleton = new KindConverter();
//     }
//
//     internal class PurpleParseStringConverter : JsonConverter
//     {
//         public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);
//
//         public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//         {
//             if (reader.TokenType == JsonToken.Null) return null;
//             var value = serializer.Deserialize<string>(reader);
//             long l;
//             if (Int64.TryParse(value, out l))
//             {
//                 return l;
//             }
//             throw new Exception("Cannot unmarshal type long");
//         }
//
//         public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//         {
//             if (untypedValue == null)
//             {
//                 serializer.Serialize(writer, null);
//                 return;
//             }
//             var value = (long)untypedValue;
//             serializer.Serialize(writer, value.ToString());
//             return;
//         }
//
//         public static readonly PurpleParseStringConverter Singleton = new PurpleParseStringConverter();
//     }
//
//     internal class ApiplatformConverter : JsonConverter
//     {
//         public override bool CanConvert(Type t) => t == typeof(Apiplatform) || t == typeof(Apiplatform?);
//
//         public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//         {
//             if (reader.TokenType == JsonToken.Null) return null;
//             var value = serializer.Deserialize<string>(reader);
//             if (value == "dotnet")
//             {
//                 return Apiplatform.Dotnet;
//             }
//             throw new Exception("Cannot unmarshal type Apiplatform");
//         }
//
//         public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//         {
//             if (untypedValue == null)
//             {
//                 serializer.Serialize(writer, null);
//                 return;
//             }
//             var value = (Apiplatform)untypedValue;
//             if (value == Apiplatform.Dotnet)
//             {
//                 serializer.Serialize(writer, "dotnet");
//                 return;
//             }
//             throw new Exception("Cannot marshal type Apiplatform");
//         }
//
//         public static readonly ApiplatformConverter Singleton = new ApiplatformConverter();
//     }
//
//     internal class AuthorConverter : JsonConverter
//     {
//         public override bool CanConvert(Type t) => t == typeof(Author) || t == typeof(Author?);
//     
//         public override object ReadJson(JsonReader reader, Type t, object? existingValue, JsonSerializer serializer)
//         {
//             if (reader.TokenType == JsonToken.Null) return null;
//             var value = serializer.Deserialize<string>(reader);
//             
//             switch (value)
//             {
//                 case "BillWagner":
//                     return Author.BillWagner;
//                 case "KrzysztofCwalina":
//                     return Author.KrzysztofCwalina;
//                 case "dotnet-bot":
//                     return Author.DotnetBot;
//             }
//
//             // if (Author.TryParse(value, out Author l))
//             // {
//             //     return l;
//             // }
//
//            throw new Exception("Cannot unmarshal type Author");
//            
//         }
//         
//         
//     
//         public override void WriteJson(JsonWriter writer, object? untypedValue, JsonSerializer serializer)
//         {
//             if (untypedValue == null)
//             {
//                 serializer.Serialize(writer, null);
//                 return;
//             }
//             var value = (Author)untypedValue;
//             switch (value)
//             {
//                 case Author.BillWagner:
//                     serializer.Serialize(writer, "BillWagner");
//                     return;
//                 case Author.KrzysztofCwalina:
//                     serializer.Serialize(writer, "KrzysztofCwalina");
//                     return;
//                 case Author.DotnetBot:
//                     serializer.Serialize(writer, "dotnet-bot");
//                     return;
//             }
//             throw new Exception("Cannot marshal type Author");
//         }
//     
//         public static readonly AuthorConverter Singleton = new AuthorConverter();
//     }
//     
//     internal class BreadcrumbPathConverter : JsonConverter
//     {
//         public override bool CanConvert(Type t) => t == typeof(BreadcrumbPath) || t == typeof(BreadcrumbPath?);
//     
//         public override object ReadJson(JsonReader reader, Type t, object? existingValue, JsonSerializer serializer)
//         {
//             if (reader.TokenType == JsonToken.Null) return null;
//             var value = serializer.Deserialize<string>(reader);
//             if (value == "/dotnet/breadcrumb/toc.json")
//             {
//                 return BreadcrumbPath.DotnetBreadcrumbTocJson;
//             }
//             throw new Exception("Cannot unmarshal type BreadcrumbPath");
//         }
//     
//         public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//         {
//             if (untypedValue == null)
//             {
//                 serializer.Serialize(writer, null);
//                 return;
//             }
//             var value = (BreadcrumbPath)untypedValue;
//             if (value == BreadcrumbPath.DotnetBreadcrumbTocJson)
//             {
//                 serializer.Serialize(writer, "/dotnet/breadcrumb/toc.json");
//                 return;
//             }
//             throw new Exception("Cannot marshal type BreadcrumbPath");
//         }
//     
//         public static readonly BreadcrumbPathConverter Singleton = new BreadcrumbPathConverter();
//     }
//
//     internal class ColorSchemeConverter : JsonConverter
//     {
//         public override bool CanConvert(Type t) => t == typeof(ColorScheme) || t == typeof(ColorScheme?);
//     
//         public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//         {
//             if (reader.TokenType == JsonToken.Null) return null;
//             var value = serializer.Deserialize<string>(reader);
//             if (value == "light dark")
//             {
//                 return ColorScheme.LightDark;
//             }
//             throw new Exception("Cannot unmarshal type ColorScheme");
//         }
//     
//         public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//         {
//             if (untypedValue == null)
//             {
//                 serializer.Serialize(writer, null);
//                 return;
//             }
//             var value = (ColorScheme)untypedValue;
//             if (value == ColorScheme.LightDark)
//             {
//                 serializer.Serialize(writer, "light dark");
//                 return;
//             }
//             throw new Exception("Cannot marshal type ColorScheme");
//         }
//     
//         public static readonly ColorSchemeConverter Singleton = new ColorSchemeConverter();
//     }
//
//     internal class DepotNameConverter : JsonConverter
//     {
//         public override bool CanConvert(Type t) => t == typeof(DepotName) || t == typeof(DepotName?);
//     
//         public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//         {
//             if (reader.TokenType == JsonToken.Null) return null;
//             var value = serializer.Deserialize<string>(reader);
//             switch (value)
//             {
//                 case "VS.core-docs":
//                     return DepotName.VsCoreDocs;
//                 case "VS.dotnet-api-docs":
//                     return DepotName.VsDotnetApiDocs;
//             }
//             throw new Exception("Cannot unmarshal type DepotName");
//         }
//     
//         public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//         {
//             if (untypedValue == null)
//             {
//                 serializer.Serialize(writer, null);
//                 return;
//             }
//             var value = (DepotName)untypedValue;
//             switch (value)
//             {
//                 case DepotName.VsCoreDocs:
//                     serializer.Serialize(writer, "VS.core-docs");
//                     return;
//                 case DepotName.VsDotnetApiDocs:
//                     serializer.Serialize(writer, "VS.dotnet-api-docs");
//                     return;
//             }
//             throw new Exception("Cannot marshal type DepotName");
//         }
//     
//         public static readonly DepotNameConverter Singleton = new DepotNameConverter();
//     }
//
//     internal class LocaleConverter : JsonConverter
//     {
//         public override bool CanConvert(Type t) => t == typeof(Locale) || t == typeof(Locale?);
//
//         public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//         {
//             if (reader.TokenType == JsonToken.Null) return null;
//             var value = serializer.Deserialize<string>(reader);
//             if (value == "en-us")
//             {
//                 return Locale.EnUs;
//             }
//             throw new Exception("Cannot unmarshal type Locale");
//         }
//
//         public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//         {
//             if (untypedValue == null)
//             {
//                 serializer.Serialize(writer, null);
//                 return;
//             }
//             var value = (Locale)untypedValue;
//             if (value == Locale.EnUs)
//             {
//                 serializer.Serialize(writer, "en-us");
//                 return;
//             }
//             throw new Exception("Cannot marshal type Locale");
//         }
//
//         public static readonly LocaleConverter Singleton = new LocaleConverter();
//     }
//
//     internal class OgTypeConverter : JsonConverter
//     {
//         public override bool CanConvert(Type t) => t == typeof(OgType) || t == typeof(OgType?);
//
//         public override object ReadJson(JsonReader reader, Type t, object? existingValue, JsonSerializer serializer)
//         {
//             if (reader.TokenType == JsonToken.Null) return null;
//             var value = serializer.Deserialize<string>(reader);
//             if (value == "website")
//             {
//                 return OgType.Website;
//             }
//             throw new Exception("Cannot unmarshal type OgType");
//         }
//
//         public override void WriteJson(JsonWriter writer, object? untypedValue, JsonSerializer serializer)
//         {
//             if (untypedValue == null)
//             {
//                 serializer.Serialize(writer, null);
//                 return;
//             }
//             var value = (OgType)untypedValue;
//             if (value == OgType.Website)
//             {
//                 serializer.Serialize(writer, "website");
//                 return;
//             }
//             throw new Exception("Cannot marshal type OgType");
//         }
//
//         public static readonly OgTypeConverter Singleton = new OgTypeConverter();
//     }
//
//     internal class FluffyParseStringConverter : JsonConverter
//     {
//         public override bool CanConvert(Type t) => t == typeof(bool) || t == typeof(bool?);
//
//         public override object ReadJson(JsonReader reader, Type t, object? existingValue, JsonSerializer serializer)
//         {
//             if (reader.TokenType == JsonToken.Null) return null;
//             var value = serializer.Deserialize<string>(reader);
//             bool b;
//             if (Boolean.TryParse(value, out b))
//             {
//                 return b;
//             }
//             throw new Exception("Cannot unmarshal type bool");
//         }
//
//         public override void WriteJson(JsonWriter writer, object? untypedValue, JsonSerializer serializer)
//         {
//             if (untypedValue == null)
//             {
//                 serializer.Serialize(writer, null);
//                 return;
//             }
//             var value = (bool)untypedValue;
//             var boolString = value ? "true" : "false";
//             serializer.Serialize(writer, boolString);
//             return;
//         }
//
//         public static readonly FluffyParseStringConverter Singleton = new FluffyParseStringConverter();
//     }
//
//     internal class TwitterCardConverter : JsonConverter
//     {
//         public override bool CanConvert(Type t) => t == typeof(TwitterCard) || t == typeof(TwitterCard?);
//
//         public override object ReadJson(JsonReader reader, Type t, object? existingValue, JsonSerializer serializer)
//         {
//             if (reader.TokenType == JsonToken.Null) return null;
//             var value = serializer.Deserialize<string>(reader);
//             if (value == "summary")
//             {
//                 return TwitterCard.Summary;
//             }
//             throw new Exception("Cannot unmarshal type TwitterCard");
//         }
//
//         public override void WriteJson(JsonWriter writer, object? untypedValue, JsonSerializer serializer)
//         {
//             if (untypedValue == null)
//             {
//                 serializer.Serialize(writer, null);
//                 return;
//             }
//             var value = (TwitterCard)untypedValue;
//             if (value == TwitterCard.Summary)
//             {
//                 serializer.Serialize(writer, "summary");
//                 return;
//             }
//             throw new Exception("Cannot marshal type TwitterCard");
//         }
//
//         public static readonly TwitterCardConverter Singleton = new TwitterCardConverter();
//     }
//
//     internal class TwitterSiteConverter : JsonConverter
//     {
//         public override bool CanConvert(Type t) => t == typeof(TwitterSite) || t == typeof(TwitterSite?);
//
//         public override object ReadJson(JsonReader reader, Type t, object? existingValue, JsonSerializer serializer)
//         {
//             if (reader.TokenType == JsonToken.Null) return null;
//             var value = serializer.Deserialize<string>(reader);
//             if (value == "@docsmsft")
//             {
//                 return TwitterSite.Docsmsft;
//             }
//             throw new Exception("Cannot unmarshal type TwitterSite");
//         }
//
//         public override void WriteJson(JsonWriter writer, object? untypedValue, JsonSerializer serializer)
//         {
//             if (untypedValue == null)
//             {
//                 serializer.Serialize(writer, null);
//                 return;
//             }
//             var value = (TwitterSite)untypedValue;
//             if (value == TwitterSite.Docsmsft)
//             {
//                 serializer.Serialize(writer, "@docsmsft");
//                 return;
//             }
//             throw new Exception("Cannot marshal type TwitterSite");
//         }
//
//         public static readonly TwitterSiteConverter Singleton = new TwitterSiteConverter();
//     }
//
//     internal class ViewportConverter : JsonConverter
//     {
//         public override bool CanConvert(Type t) => t == typeof(Viewport) || t == typeof(Viewport?);
//
//         public override object ReadJson(JsonReader reader, Type t, object? existingValue, JsonSerializer serializer)
//         {
//             if (reader.TokenType == JsonToken.Null) return null;
//             var value = serializer.Deserialize<string>(reader);
//             if (value == "width=device-width, initial-scale=1.0")
//             {
//                 return Viewport.WidthDeviceWidthInitialScale10;
//             }
//             throw new Exception("Cannot unmarshal type Viewport");
//         }
//
//         public override void WriteJson(JsonWriter writer, object? untypedValue, JsonSerializer serializer)
//         {
//             if (untypedValue == null)
//             {
//                 serializer.Serialize(writer, null);
//                 return;
//             }
//             var value = (Viewport)untypedValue;
//             if (value == Viewport.WidthDeviceWidthInitialScale10)
//             {
//                 serializer.Serialize(writer, "width=device-width, initial-scale=1.0");
//                 return;
//             }
//             throw new Exception("Cannot marshal type Viewport");
//         }
//
//         public static readonly ViewportConverter Singleton = new ViewportConverter();
//     }
//
