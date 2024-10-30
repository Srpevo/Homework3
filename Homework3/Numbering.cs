using System;

namespace EasyNumbering
{
    internal class Numbering
    {

        public static void PrintWithColor(int value, Colors color)
        {

            var originalColor = Console.ForegroundColor;
            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine("#{0}", value);
            Console.ForegroundColor = originalColor;
        }
    }

    public enum Colors
    {
        Green = ConsoleColor.Green,
        Yellow = ConsoleColor.Yellow,
        Red = ConsoleColor.Red,
        White = ConsoleColor.White
    }
}
