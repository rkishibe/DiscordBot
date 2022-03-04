using Newtonsoft.Json;

namespace DiscordBot.Models;

public static class Serialize
{
        public static string ToJson(this Weather self) => JsonConvert.SerializeObject(self, Converter.Settings);
        
        public static string ToJson(this DocumentationData self) => JsonConvert.SerializeObject(self, Converter.Settings);
}