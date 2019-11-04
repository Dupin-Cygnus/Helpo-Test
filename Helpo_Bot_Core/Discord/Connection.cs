using Discord;
using Discord.WebSocket;
using Helpo_Bot_Core.Discord.Entities;
using System;
using System.Threading.Tasks;

namespace Helpo_Bot_Core.Discord
{
    public class Connection
    {

        private DiscordSocketClient _client;
        private DiscordLogger _logger;

        public Connection(DiscordLogger logger)
        {
            _logger = logger;
        }


        internal async Task ConnectAsync(HelpoBotConfig config)
        {
            _client = new DiscordSocketClient(config.SocketConfig);

            _client.Log += _logger.Log;
        }
    }
}
