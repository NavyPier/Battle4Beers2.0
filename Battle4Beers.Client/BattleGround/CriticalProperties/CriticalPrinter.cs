using Battle4Beers.Client.Models;
using System;

namespace Battle4Beers.Client.BattleGround
{
    public class CriticalPrinter
    {
        public static void PrintCritical(Hero player)
        {
            var key = new ConsoleKeyInfo();
            while(key.Key != ConsoleKey.Enter)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"{player.Name} LANDED A CRITICAL STRIKE!!!");
                Console.WriteLine($"{player.Name} LANDED A CRITICAL STRIKE!!!");
                Console.WriteLine($"{player.Name} LANDED A CRITICAL STRIKE!!!");
                Console.WriteLine($"{player.Name} LANDED A CRITICAL STRIKE!!!");
                Console.WriteLine($"{player.Name} LANDED A CRITICAL STRIKE!!!");
                Console.WriteLine($"{player.Name} LANDED A CRITICAL STRIKE!!!");
                Console.WriteLine("------------- PRESS ENTER ----------------");
                key = Console.ReadKey();
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
