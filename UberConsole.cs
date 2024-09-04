using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Game
{
    internal static class UberConsole
    {
        public static void WriteLine(string text, ConsoleColor color)
        {
            ConsoleColor previusColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = previusColor;
        }
    }
}
