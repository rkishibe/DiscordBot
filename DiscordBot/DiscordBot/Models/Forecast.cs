using Newtonsoft.Json;
namespace DiscordBot.Models;
    
     public partial class Forecast
    {
        [JsonProperty("lat", NullValueHandling = NullValueHandling.Ignore)]
        public double? Lat { get; set; }

        [JsonProperty("lon", NullValueHandling = NullValueHandling.Ignore)]
        public double? Lon { get; set; }

        [JsonProperty("timezone", NullValueHandling = NullValueHandling.Ignore)]
        public string Timezone { get; set; }

        [JsonProperty("timezone_offset", NullValueHandling = NullValueHandling.Ignore)]
        public long? TimezoneOffset { get; set; }

        [JsonProperty("current", NullValueHandling = NullValueHandling.Ignore)]
        public Current Current { get; set; }

        [JsonProperty("daily", NullValueHandling = NullValueHandling.Ignore)]
        public Daily[] Daily { get; set; }
    }

    public partial class Current
    {
        [JsonProperty("dt", NullValueHandling = NullValueHandling.Ignore)]
        public long? Dt { get; set; }

        [JsonProperty("sunrise", NullValueHandling = NullValueHandling.Ignore)]
        public long? Sunrise { get; set; }

        [JsonProperty("sunset", NullValueHandling = NullValueHandling.Ignore)]
        public long? Sunset { get; set; }

        [JsonProperty("temp", NullValueHandling = NullValueHandling.Ignore)]
        public double? Temp { get; set; }

        [JsonProperty("feels_like", NullValueHandling = NullValueHandling.Ignore)]
        public double? FeelsLike { get; set; }

        [JsonProperty("pressure", NullValueHandling = NullValueHandling.Ignore)]
        public long? Pressure { get; set; }

        [JsonProperty("humidity", NullValueHandling = NullValueHandling.Ignore)]
        public long? Humidity { get; set; }

        [JsonProperty("dew_point", NullValueHandling = NullValueHandling.Ignore)]
        public double? DewPoint { get; set; }

        [JsonProperty("uvi", NullValueHandling = NullValueHandling.Ignore)]
        public double? Uvi { get; set; }

        [JsonProperty("clouds", NullValueHandling = NullValueHandling.Ignore)]
        public long? Clouds { get; set; }

        [JsonProperty("visibility", NullValueHandling = NullValueHandling.Ignore)]
        public long? Visibility { get; set; }

        [JsonProperty("wind_speed", NullValueHandling = NullValueHandling.Ignore)]
        public double? WindSpeed { get; set; }

        [JsonProperty("wind_deg", NullValueHandling = NullValueHandling.Ignore)]
        public long? WindDeg { get; set; }

        [JsonProperty("weather", NullValueHandling = NullValueHandling.Ignore)]
        public Weather[] Weather { get; set; }
    }


    public partial class Daily
    {
        [JsonProperty("dt", NullValueHandling = NullValueHandling.Ignore)]
        public long? Dt { get; set; }

        [JsonProperty("sunrise", NullValueHandling = NullValueHandling.Ignore)]
        public long? Sunrise { get; set; }

        [JsonProperty("sunset", NullValueHandling = NullValueHandling.Ignore)]
        public long? Sunset { get; set; }

        [JsonProperty("moonrise", NullValueHandling = NullValueHandling.Ignore)]
        public long? Moonrise { get; set; }

        [JsonProperty("moonset", NullValueHandling = NullValueHandling.Ignore)]
        public long? Moonset { get; set; }

        [JsonProperty("moon_phase", NullValueHandling = NullValueHandling.Ignore)]
        public double? MoonPhase { get; set; }

        [JsonProperty("temp", NullValueHandling = NullValueHandling.Ignore)]
        public Temp Temp { get; set; }

        [JsonProperty("feels_like", NullValueHandling = NullValueHandling.Ignore)]
        public FeelsLike FeelsLike { get; set; }

        [JsonProperty("pressure", NullValueHandling = NullValueHandling.Ignore)]
        public long? Pressure { get; set; }

        [JsonProperty("humidity", NullValueHandling = NullValueHandling.Ignore)]
        public long? Humidity { get; set; }

        [JsonProperty("dew_point", NullValueHandling = NullValueHandling.Ignore)]
        public double? DewPoint { get; set; }

        [JsonProperty("wind_speed", NullValueHandling = NullValueHandling.Ignore)]
        public double? WindSpeed { get; set; }

        [JsonProperty("wind_deg", NullValueHandling = NullValueHandling.Ignore)]
        public long? WindDeg { get; set; }

        [JsonProperty("wind_gust", NullValueHandling = NullValueHandling.Ignore)]
        public double? WindGust { get; set; }

        [JsonProperty("weather", NullValueHandling = NullValueHandling.Ignore)]
        public Weather[] Weather { get; set; }

        [JsonProperty("clouds", NullValueHandling = NullValueHandling.Ignore)]
        public long? Clouds { get; set; }

        [JsonProperty("pop", NullValueHandling = NullValueHandling.Ignore)]
        public double? Pop { get; set; }

        [JsonProperty("uvi", NullValueHandling = NullValueHandling.Ignore)]
        public double? Uvi { get; set; }

        [JsonProperty("rain", NullValueHandling = NullValueHandling.Ignore)]
        public double? Rain { get; set; }
    }

    public partial class FeelsLike
    {
        [JsonProperty("day", NullValueHandling = NullValueHandling.Ignore)]
        public double? Day { get; set; }

        [JsonProperty("night", NullValueHandling = NullValueHandling.Ignore)]
        public double? Night { get; set; }

        [JsonProperty("eve", NullValueHandling = NullValueHandling.Ignore)]
        public double? Eve { get; set; }

        [JsonProperty("morn", NullValueHandling = NullValueHandling.Ignore)]
        public double? Morn { get; set; }
    }

    public partial class Temp
    {
        [JsonProperty("day", NullValueHandling = NullValueHandling.Ignore)]
        public double? Day { get; set; }

        [JsonProperty("min", NullValueHandling = NullValueHandling.Ignore)]
        public double? Min { get; set; }

        [JsonProperty("max", NullValueHandling = NullValueHandling.Ignore)]
        public double? Max { get; set; }

        [JsonProperty("night", NullValueHandling = NullValueHandling.Ignore)]
        public double? Night { get; set; }

        [JsonProperty("eve", NullValueHandling = NullValueHandling.Ignore)]
        public double? Eve { get; set; }

        [JsonProperty("morn", NullValueHandling = NullValueHandling.Ignore)]
        public double? Morn { get; set; }
    }

public partial class Forecast
{
    public static Forecast FromJson(string json) => JsonConvert.DeserializeObject<Forecast>(json, Converter.Settings);
}


    