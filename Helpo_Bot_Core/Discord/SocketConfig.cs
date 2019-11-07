using Discord.WebSocket;
using Discord;
using System;

// If Discord library updates, change the configuration here
namespace Helpo_Bot_Core.Discord
{
    public static class SocketConfig
    {
        public static DiscordSocketConfig GetDefault()
        {
            Console.WriteLine("GetDefault version of DiscordSocketConfig created.");
            return new DiscordSocketConfig
            {
                LogLevel = LogSeverity.Verbose
            };
        }

        public static DiscordSocketConfig GetNew()
        {
            return new DiscordSocketConfig();
        }
    }
}
