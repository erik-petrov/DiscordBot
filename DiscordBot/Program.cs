using DSharpPlus;
using DSharpPlus.CommandsNext;
using DiscordBot.commands;
using System;
using System.Threading.Tasks;

namespace DiscordBot
{
    class Program
    {
        static void Main(string[] args)
        {
            //MainAsync(args).ConfigureAwait(false).GetAwaiter().GetResult();
            MainAsync().GetAwaiter().GetResult();
        }
        static async Task MainAsync()
        {
            var discord = new DiscordClient(new DiscordConfiguration()
            {
                //хард код токен - потом убрать.
                Token = "ODE4MDY5MzgxNjY5OTc4MTUy.YESsew.JnosFeFaXm99YfPAZM5k4I8gkeI",
                TokenType = TokenType.Bot
            });

            /*discord.MessageCreated += async (s, e) =>
            {
                if (e.Message.Content.ToLower().StartsWith("пидр"))
                    await e.Message.RespondAsync("лёха");
            };*/
            //код выше отвечает на пидр

            var commands = discord.UseCommandsNext(new CommandsNextConfiguration()
            { 
                StringPrefixes = new[] {".."}
            });

            commands.RegisterCommands<Greet>();

            await discord.ConnectAsync();
            await Task.Delay(-1);

        }
    }
}
