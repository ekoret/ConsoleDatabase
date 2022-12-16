﻿

namespace ConsoleDatabase
{
    public class ConsoleFormatter
    {
        public static void IndentSpaces(int amount = 8)
        {
            Console.Write(string.Concat(Enumerable.Repeat(" ", amount)));
        }

        public static void AddDivider(int length = 10, bool pad = false)
        {
            if (pad)
            {
                Console.WriteLine("\n" + string.Concat(Enumerable.Repeat("-", length)) + "\n");
            } else
            {
                Console.WriteLine(string.Concat(Enumerable.Repeat("-", length)));
            }
            
        }
    }
}
