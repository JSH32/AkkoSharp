using System;
using System.Threading.Tasks;
using Akko.Services;
using Akko.Config;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace Akko
{
    public class Bot
    {
        private Model _config;
        public Bot(Model config)
        {
            _config = config;
        }
        
        private DiscordSocketClient _client;
        public async Task MainAsync()
        {
            _client = new DiscordSocketClient();

            _client.Log += Log;
            
            await _client.LoginAsync(TokenType.Bot, _config.Token);
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