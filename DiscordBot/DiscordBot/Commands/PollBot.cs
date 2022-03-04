using Discord.Commands;
using Discord;

namespace DiscordBot.Commands;

public class PollBot : ModuleBase<SocketCommandContext>
{
    [Command("poll")]
    public async Task CreatePoll(string question = null)
    {
        if (String.IsNullOrEmpty(question))
        {
            await Context.Channel.TriggerTypingAsync();
            await ReplyAsync("You didn't write a question.");
            return;
        }

        // var embed = new EmbedBuilder()
        //  .WithTitle(question)
        //  .WithColor(new Color(0, 0, 0))
        //  .AddField("Option 1",":thumbsup: Yes")
        //  .AddField("Option 2",":thumbsdown: No")
        //  .Build();

        var message = await ReplyAsync($"**{question}**\n Option 1: :thumbsup: Yes\n Option 2: :thumbsdown: No");
        Emoji emoji1 = new Emoji("👍");
        Emoji emoji2 = new Emoji("👎");

        await message.AddReactionAsync(emoji1);
        await message.AddReactionAsync(emoji2);
    }
}