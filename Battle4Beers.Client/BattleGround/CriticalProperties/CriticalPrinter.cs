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
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("First team to attack:".ToString().Length / 2)) + "}"
            , $"{player.Name} LANDED A CRITICAL STRIKE!!!"));
                }
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("First team to attack:".ToString().Length / 2)) + "}"
            , "          ------------- PRESS ENTER ----------------"));
                key = Console.ReadKey();
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
