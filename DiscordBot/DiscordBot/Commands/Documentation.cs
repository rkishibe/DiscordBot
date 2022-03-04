using Discord;
using Discord.Commands;
using DiscordBot.Models;

namespace DiscordBot.Commands;

public class Documentation : ModuleBase<SocketCommandContext>
{
    private readonly IHttpClientFactory _httpClientFactory;

    public Documentation(IHttpClientFactory httpclientfactory)
    {
        _httpClientFactory = httpclientfactory;
    }

    [Command("doc")]
    [Summary("returns search results limited to dotnet documentation")]
    public async Task DocumentationSearch(string searchItem=null)
    {
        var httpClient = _httpClientFactory.CreateClient();
        var key = "AIzaSyCUq56fiKT393sv3Bvup-1sJFJuSu0yrIo";
        var cx = "e32af35ab4c0880a2";
        
        if (String.IsNullOrEmpty(searchItem))
        {
            await Context.Channel.TriggerTypingAsync();
            await ReplyAsync("Invalid search query.");
            return;
        }
        
        var response = await httpClient.GetStringAsync($"https://www.googleapis.com/customsearch/v1?key={key}&cx={cx}&q={searchItem}");
        var documentationData = DocumentationData.FromJson(response);
        
        var embed = new EmbedBuilder()
            .WithTitle($"Results for {searchItem}")
            .WithColor(new Color(0, 0, 0))
            .AddField("Link",$"{documentationData.Items[0].Link}",true )
            
            .Build();
        
        
            await ReplyAsync(embed:embed);
        
    }

}