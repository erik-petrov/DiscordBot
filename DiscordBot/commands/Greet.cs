using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;

namespace DiscordBot.commands
{
    class Greet : BaseCommandModule
    {
        [Command("pidor")]
        public async Task GreetCommand(CommandContext ctx, string kto_pidor)
        {
            await ctx.RespondAsync($"Кто пидор?\n Конечно же {kto_pidor}.");
        }
    }
}
