using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_07.Quest_Final.Utils
{
    public static class ConsoleUtils
    {
        public const string outPrefix = ">>>>>>>>";

        public const string inPrefix = "<<<<";

        public static void WriteLine(string line)
        {
            Console.WriteLine($"{outPrefix}{line}");
        }

        public static string? ReadLine(string line)
        {
            Console.Write($"{inPrefix}{line}");
            return Console.ReadLine();
        }
    }
}
