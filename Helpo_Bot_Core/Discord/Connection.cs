using Discord;
using Discord.WebSocket;
using Helpo_Bot_Core.Discord.Entities;
using System;
using System.Threading.Tasks;

namespace Helpo_Bot_Core.Discord
{
    public class Connection
    {

        private readonly DiscordSocketClient _client;
        private readonly DiscordLogger _logger;

        public Connection(DiscordLogger logger, DiscordSocketClient client)
        {
            _logger = logger;
            _client = client;
        }


        internal async Task ConnectAsync(HelpoBotConfig config)
        {
            _client.Log += _logger.Log;

            await _client.LoginAsync(TokenType.Bot, config.Token);
            await _client.StartAsync();

            await Task.Delay(-1);
        }
    }
}
