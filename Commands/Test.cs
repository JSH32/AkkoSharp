using System.Threading.Tasks;
using Discord.Commands;

namespace Akko.Commands
{
    public class Test : ModuleBase<SocketCommandContext>
    {
        [Command("say")]
        [Summary("Echoes a message.")]
        public Task SayAsync([Remainder] [Summary("The text to echo")] string echo)
            => ReplyAsync("Hello");
    }
}