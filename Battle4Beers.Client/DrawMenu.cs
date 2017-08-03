using System;
using Battle4Beers.Client.Models;
using Battle4Beers.Client.Utilities.Constants;
using System.Collections.Generic;
using System.Linq;

namespace Battle4Beers.Client
{
    public class DrawMenu
    {
        public static List<string> actions;

        // This is the method used to draw all the different types of menus.
        public static void MenuDraw(List<string> currentActions)
        {
            actions = new List<string> (currentActions);
            var index = 1;
            var key = new ConsoleKeyInfo();
            while(key.Key != ConsoleKey.Enter)
            {
                currentActions = new List<string>(actions);
                Console.Clear();
                if(key.Key == ConsoleKey.DownArrow)
                {
                    index++;
                }
                else if(key.Key == ConsoleKey.UpArrow)
                {
                    index--;
                }

                if(index < 1)
                {
                    index = currentActions.Count - 1;
                }
                else if(index >= currentActions.Count)
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
            manager.DoAction(command.Substring(4, command.Length - 4));
        } 

        //Gives the MenuDraw method the properties needed to draw the Start Menu.
        public static void StartMenu()
        {
            var title = "WELCOME TO BATTLE FOR BEERS!";
            var newGame = "NEW GAME";
            var beersEarned = "BEERS EARNED";
            var instructions = "INSTRUCTIONS";
            var quit = "QUIT";
            MenuDraw(new List<string>() {title, newGame, beersEarned, instructions, quit });
        }

        //Gives the MenuDraw method the properties needed to draw an Action Menu for the current hero.
        public static void ActionsMenu(Hero player)
        {
            var title = "SELECT AN ACTION:";
            var firstAction = player.Actions[0].ToString();
            var secondAction = player.Actions[1].ToString();
            var thirdAction = player.Actions[2].ToString();
            var fourthAction = player.Actions[3].ToString();
            MenuDraw(new List<string>() { title, firstAction, secondAction, thirdAction, fourthAction });
        }

        public static void NewGameMenu()
        {
            var title = "What type of game would you like to play?";
            var duelOption = "Duel between 2 players.";
            var arenaOption = "Arena battle between 2 teams, each of 2 players.";
            MenuDraw(new List<string>() { title, duelOption, arenaOption });
        }
    }
}
