using Discord;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Helpo_Bot_Core.Discord
{
    public class DiscordLogger
    {
        private ILogger _logger;


        public DiscordLogger(ILogger logger)
        {
            _logger = logger;
        }

        // Takes Discord message, sends it to bot's current Logging method
        //  bot's logging method is determined by Logger implementation
        public Task Log(LogMessage logMsg)
        {
            _logger.Log(logMsg.Message);
            return Task.CompletedTask;
        }
    }
}
