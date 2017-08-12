using Battle4Beers.Client.Utilities.Constants;
using System;
using System.Collections.Generic;

namespace Battle4Beers.Client.BattleGround
{
    public class ActionResult
    {
        public static void ShowActionResult(string result)
        {
            var key = new ConsoleKeyInfo();
            while(key.Key != ConsoleKey.Enter)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Constants.GameTitle);
                Console.WriteLine(result);
                Console.WriteLine("-- PRESS ENTER TO CONTINUE FURTHER --");
                key = Console.ReadKey();
            }
        }
    }
}
