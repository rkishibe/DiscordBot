using Discord;
using Discord.Commands;
using DiscordBot.Models;
using Microsoft.Extensions.Configuration;

namespace DiscordBot.Commands;

public class Weather : ModuleBase<SocketCommandContext>
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly IConfiguration _configuration;

    public Weather(IHttpClientFactory httpclientfactory, IConfiguration configuration)
    {
        _httpClientFactory = httpclientfactory;
        _configuration = configuration;
    }

    [Command("wtoday")]
    [Summary("provides info about today's weather in a given location")]
    public async Task WeatherTodayAsync(string? location = null)
    {
        Random rnd = new Random();
        var httpClient = _httpClientFactory.CreateClient();
        var API_key = "ca4eabd11d479065f4bd36ba2fc79103";

        if (String.IsNullOrEmpty(location) || String.IsNullOrWhiteSpace(location))
        {
            await Context.Channel.TriggerTypingAsync();
            await ReplyAsync("Please provide a location.");
            return;
        }

        // var response =
        //     await httpClient.GetStringAsync(
        //         $"https://api.openweathermap.org/data/2.5/weather?q={location}&appid={_configuration.GetSection("Wtoday: API key").Value}&units=metric");
        // var weatherData = WeatherData.FromJson(response);
        await ReplyAsync(_configuration.GetSection("Wtoday: key").Value);
        // var embed = new EmbedBuilder()
        //     .WithTitle($"Weather today in {weatherData.Name}")
        //     .WithColor(new Color(rnd.Next(256), rnd.Next(256), rnd.Next(256)))
        //     .AddField("Temperature", weatherData.Main.Temp + "°C", true)
        //     .AddField("Feels Like", weatherData.Main.FeelsLike + "°C", true)
        //     .AddField("Humidity", weatherData.Main.Humidity + "%", true)
        //     .Build();


        // if (weatherData != null)
        // {
        //     await Context.Channel.TriggerTypingAsync();
        //     await ReplyAsync(_configuration.GetSection("Wtoday: API key").Value);
        //     // await ReplyAsync(embed: embed);
        // }
    }

    //[Command("forecast")]
    //[Summary("")]
    // public async Task Forecast(string? location = null)
    // {
    //     Random rnd = new Random();
    //     var httpClient = _httpClientFactory.CreateClient();
    //     var API_key = "ca4eabd11d479065f4bd36ba2fc79103";
    //
    //     if (String.IsNullOrEmpty(location) || String.IsNullOrWhiteSpace(location))
    //     {
    //         await Context.Channel.TriggerTypingAsync();
    //         await ReplyAsync("Please provide a location.");
    //         return;
    //     }
    //
    //     var geocoding =
    //         await httpClient.GetStringAsync(
    //             $"http://api.openweathermap.org/geo/1.0/direct?q={location}&limit=1&appid={API_key}");
    //     var geocodingData = Forecast.FromJson(geocoding);
    //     
    //     var response =
    //         await httpClient.GetStringAsync(
    //             $"https://api.openweathermap.org/data/2.5/onecall?lat={geocodingData.Lat}&lon={geocodingData.Lon}&exclude=minutely,hourly&appid={API_key}&units=metric");
    //     var weatherData = Forecast.FromJson(response);
    //     var embed = new EmbedBuilder()
    //         //.WithTitle($"Weather today in {weatherData.Name}")
    //         .WithColor(new Color(rnd.Next(256), rnd.Next(256), rnd.Next(256)))
    //         .AddField("Location", location, true)
    //         .AddField("Temperature", weatherData.Daily + "°C", true)
    //         //.AddField("Humidity", weatherData.Main.Humidity + "%", true)
    //         .Build();
    //     
    //     if (weatherData != null)
    //     {
    //         await Context.Channel.TriggerTypingAsync();
    //         await ReplyAsync(embed: embed);
    //     }
    // }
}