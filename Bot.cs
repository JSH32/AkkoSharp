using System;
using System.Threading.Tasks;
using Akko.Services;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace Akko
{
    public class Bot
    {
        private DiscordSocketClient _client;
        public async Task MainAsync()
        {
            _client = new DiscordSocketClient();

            _client.Log += Log;
            
            await _client.LoginAsync(TokenType.Bot, Config.Config.Token);
            await _client.StartAsync();
            
            _client.MessageReceived += MessageReceived;
            
            new CommandHandler(_client, new CommandService());

            // Block this task until the program is closed.
            await Task.Delay(-1);
        }
        
        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }
        
        private async Task MessageReceived(SocketMessage message)
        {
           
        }
    }
}