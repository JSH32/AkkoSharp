using System;
using System.Threading.Tasks;
using Discord.WebSocket;

namespace Akko.Events
{
    public class MessageRecieved
    {
        internal async Task MessageReceived(SocketMessage message)
        {
            Console.WriteLine(message);
        }
    }
}
