using Helpo_Bot_Core.Discord;
using Helpo_Bot_Core.Discord.Entities;
using System;


namespace Helpo_Bot_Core
{
    internal class Program
    {
        //able to run Main as async Task with .NET version >= 7.1
        private static void Main()
        {
            Console.WriteLine("Henlo.");

            var discordBotConfig = new HelpoBotConfig
            {
                Token = "ABC",
                SocketConfig = SocketConfig.GetDefault()
            };
        }
    }

}
