using Battle4Beers.Client.Utilities.Constants;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Battle4Beers.Client
{
    public class MenuDrawer
    {
        public static List<string> actions;

        // This is the method used to draw all the different types of menus.
        public static string DrawMenu(List<string> currentActions)
        {
            actions = new List<string>(currentActions);
            var index = 1;
            var key = new ConsoleKeyInfo();
            while (key.Key != ConsoleKey.Enter)
            {
                currentActions = new List<string>(actions);
                Console.Clear();
                if (key.Key == ConsoleKey.DownArrow)
                {
                    index++;
                }
                else if (key.Key == ConsoleKey.UpArrow)
                {
                    index--;
                }

                if (index < 1)
                {
                    index = currentActions.Count - 1;
                }
                else if (index >= currentActions.Count)
                {
                    index = 1;
                }
                currentActions[index] = "--> " + actions[index];
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Constants.GameTitle);
                Console.WriteLine("{0," + (Console.WindowWidth / 2 + 10) + "}", currentActions[0]);
                foreach (var action in currentActions.Skip(1))
                {
                    Console.WriteLine("{0," + Console.WindowWidth / 2 + "}", action);
                }
                key = Console.ReadKey();
            }
            ActionManager manager = new ActionManager();
            var command = currentActions.Where(a => a.Contains("-->")).First();
            return command.Split()[1];
        }
    }
}
