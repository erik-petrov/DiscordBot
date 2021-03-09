using DSharpPlus;
using DSharpPlus.CommandsNext;
using DiscordBot.commands;
using System;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;

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
                Token = "тут был токен",
                TokenType = TokenType.Bot
            });

            discord.MessageCreated += async (s, e) =>
            {
                if (e.Message.Content.ToLower().StartsWith("макс"))
                    await e.Message.RespondAsync("хоороший чел");
            };
            //код выше отвечает на X слово

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
