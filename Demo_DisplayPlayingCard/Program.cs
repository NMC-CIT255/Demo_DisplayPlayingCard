using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_DisplayPlayingCard
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayBasicCard();
            Console.ReadKey();

            DisplayFancyCard();
            Console.ReadKey();
        }

        private static void DisplayFancyCard()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.ResetColor();
            Console.Clear();

            char ulCorner = '\u2554';
            char llCorner = '\u255A';
            char urCorner = '\u2557';
            char lrCorner = '\u255D';
            char vertical = '\u2551';
            char horizontal = '\u2550';
            char spade = '\u2660';

            Console.WriteLine();

            Console.WriteLine(horizontal);
            Console.WriteLine(vertical);
            Console.WriteLine(ulCorner);
            Console.WriteLine(urCorner);
            Console.WriteLine(llCorner);
            Console.WriteLine(lrCorner);

            Console.WriteLine();
            Console.WriteLine(spade);

            Console.ReadKey();
        }

        public static void DisplayBasicCard()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(5, 2);
            Console.WriteLine("**********");

            for (int row = 3; row < 7; row++)
            {
                Console.SetCursorPosition(5, row);
                Console.WriteLine("*        *");
            }

            Console.SetCursorPosition(5, 7);
            Console.WriteLine("**********");

            Console.ReadKey();
        }
    }
}
