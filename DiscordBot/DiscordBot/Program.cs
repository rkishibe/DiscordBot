// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Hosting;
using Discord;
using Discord.WebSocket;
using Discord.Addons.Hosting;
using Discord.Commands;
using DiscordBot.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;

var builder = new HostBuilder()
        .ConfigureAppConfiguration(x =>
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true)
                .Build();
            x.AddConfiguration(configuration);
        })
        .ConfigureLogging(x =>
        {
            x.AddConsole();
            x.SetMinimumLevel(LogLevel.Debug);
        })
        .ConfigureDiscordHost((context, config) =>
        {
            config.SocketConfig = new DiscordSocketConfig()
            {
                LogLevel = LogSeverity.Debug,
                AlwaysDownloadUsers = false,
                MessageCacheSize = 200,
            };
            config.Token = context.Configuration["Token"];
        })
        .UseCommandService((context, config) =>
        {
            config.CaseSensitiveCommands = false;
            config.LogLevel = LogSeverity.Debug;
            config.DefaultRunMode = RunMode.Sync;
        })
        .ConfigureServices((context, services) =>
        {
             services
            .AddHostedService<CommandHandler>()
            .AddHttpClient();
        })
        .UseConsoleLifetime();
    var host = builder.Build();
    using (host)
    {
        await host.RunAsync();
    }