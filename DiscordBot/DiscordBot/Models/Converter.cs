using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DiscordBot.Models;

internal static class Converter
{
    public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
    {
        MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
        DateParseHandling = DateParseHandling.None,
        Converters =
        {
            // DisplayLinkConverter.Singleton,
            // KindConverter.Singleton,
            // ApiplatformConverter.Singleton,
            // AuthorConverter.Singleton,
            // BreadcrumbPathConverter.Singleton,
            // ColorSchemeConverter.Singleton,
            // DepotNameConverter.Singleton,
            // LocaleConverter.Singleton,
            // OgTypeConverter.Singleton,
            // TwitterCardConverter.Singleton,
            // TwitterSiteConverter.Singleton,
            // ViewportConverter.Singleton,
            new IsoDateTimeConverter {DateTimeStyles = DateTimeStyles.AssumeUniversal}
        },
    };
}