using Helpo_Bot_Core.Discord;
using Helpo_Bot_Core.Discord.Entities;
using Helpo_Bot_Core.Storage;
using Ninject;
using System;


namespace Helpo_Bot_Core
{
    internal class Program
    {
        //able to run Main as async Task with .NET version >= 7.1
        private static void Main()
        {
            //use kernel for creating class-objects that need dependency injection
            IKernel injections = new StandardKernel(new ApplicationModule());

            var a = injections.Get<IDataStorage>();

            Console.WriteLine("Henlo.");

            var discordBotConfig = new HelpoBotConfig
            {
                Token = "ABC",
                SocketConfig = SocketConfig.GetDefault()
            };

            
        }
    }

}
