﻿using Helpo_Bot_Core.Discord;
using Helpo_Bot_Core.Discord.Entities;
using Helpo_Bot_Core.Storage;
using Ninject;
using System;
using System.Threading.Tasks;

namespace Helpo_Bot_Core
{
    internal class Program
    {
        //able to run Main as async Task with .NET version >= 7.1
        private static async Task Main()
        {
            //use kernel for creating class-objects that need dependency injection
            IKernel injections = new StandardKernel(new InjectionModule());
            Console.WriteLine("Henlo.");

            var storage = injections.Get<IDataStorage>();

            var discordBotConfig = new HelpoBotConfig
            {
                Token = storage.RestoreObject<string>("Config/BotToken"),
            };

            var connection = injections.Get<Connection>();
            await connection.ConnectAsync(new HelpoBotConfig
            {
                Token = storage.RestoreObject<string>("Config/BotToken")
            });
            Console.ReadKey();

        }
    }

}
