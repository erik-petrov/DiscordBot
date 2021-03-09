using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;

namespace DiscordBot.commands
{
    class Greet : BaseCommandModule
    {
        [Command("link")]
        public async Task GreetCommand(CommandContext ctx, string name)
        {
            jsonHandler json = new jsonHandler();
            jsonHandler.Root teachers = json.table();
            foreach (jsonHandler.Teacher teacher in teachers.teachers)
            {
                if (teacher.Alias.ToLower() == name.ToLower() || teacher.Name.ToLower() == name.ToLower())
                {
                    await ctx.RespondAsync($"Ссылка на урок {teacher.Screen}: {teacher.Link}");
                    break;
                }
            }
            await Task.FromResult(0);
        }
    }
}
