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
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

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
