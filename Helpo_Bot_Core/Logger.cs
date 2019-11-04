using System;
using System.Collections.Generic;
using System.Text;

namespace Helpo_Bot_Core
{
    public class Logger : ILogger
    {
        // Message to console
        public void Log(string message)
        {
            Console.WriteLine(message);
        }

        /* If we want to add a console text color version
        public void Log(string message, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        */
    }
}
