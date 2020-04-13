using System.Threading.Tasks;
using Discord.Commands;
using Discord.WebSocket;

namespace Akko.Commands
{
    public class Test : ModuleBase<SocketCommandContext>
    {
        [Command("ping")]
        public async Task Ping()
        {
            await ReplyAsync("Pong");
        }
    }
}