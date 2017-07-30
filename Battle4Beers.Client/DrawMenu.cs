using System;
using Battle4Beers.Client.Models;
using Battle4Beers.Client.Utilities.Constants;

namespace Battle4Beers.Client
{
    public class DrawMenu
    {    
        // This is the method used to draw all the different types of menus.
        public static void MenuDraw(string firstAction, string secondAction, string thirdAction, string fourthAction)
        {
            int counter = 1;
            ConsoleKeyInfo enter = new ConsoleKeyInfo();
            while (enter.Key != ConsoleKey.Enter)
            {
                if (enter.Key == ConsoleKey.DownArrow)
                {
                    counter++;
                }
                else if (enter.Key == ConsoleKey.UpArrow)
                {
                    counter--;
                }

                //The game title.
                Console.WriteLine(Constants.GameTitle);

                //Draws the menu with an arrow pointing to the currently selected action.
                switch (counter)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (firstAction.Length / 2)) + "}", "-> " + firstAction);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (secondAction.Length / 2)) + "}", secondAction);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (thirdAction.Length / 2)) + "}", thirdAction);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (fourthAction.Length / 2)) + "}", fourthAction); break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (firstAction.Length / 2)) + "}", firstAction);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (secondAction.Length / 2)) + "}", "-> " + secondAction);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (thirdAction.Length / 2)) + "}", thirdAction);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (fourthAction.Length / 2)) + "}", fourthAction); break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (firstAction.Length / 2)) + "}", firstAction);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (secondAction.Length / 2)) + "}", secondAction);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (thirdAction.Length / 2)) + "}", "-> " + thirdAction);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (fourthAction.Length / 2)) + "}", fourthAction); break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (firstAction.Length / 2)) + "}", firstAction);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (secondAction.Length / 2)) + "}", secondAction);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (thirdAction.Length / 2)) + "}", thirdAction);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (fourthAction.Length / 2)) + "}", "-> " + fourthAction);
                        break;
                    default:
                        if (counter == 5)
                        {
                            counter = 1;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (firstAction.Length / 2)) + "}", "-> " + firstAction);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (secondAction.Length / 2)) + "}", secondAction);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (thirdAction.Length / 2)) + "}", thirdAction);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (fourthAction.Length / 2)) + "}", fourthAction);
                        }
                        else if (counter == 0)
                        {
                            counter = 4;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (firstAction.Length / 2)) + "}", firstAction);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (secondAction.Length / 2)) + "}", secondAction);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (thirdAction.Length / 2)) + "}", thirdAction);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (fourthAction.Length / 2)) + "}", "-> " + fourthAction);
                        }
                        break;
                }
                enter = Console.ReadKey();
                Console.Clear();
            }

            ActionManager actionManager = new ActionManager();
            switch (counter)
            {
                case 1:
                    actionManager.DoAction(firstAction);
                    break;
                case 2:
                    actionManager.DoAction(secondAction);
                    break;
                case 3:
                    actionManager.DoAction(thirdAction);
                    break;
                case 4:
                    actionManager.DoAction(fourthAction);
                    break;
            }
        }

        //Gives the MenuDraw method the properties needed to draw the Start Menu.
        public static void StartMenu()
        {
            var firstAction = "NEW GAME";
            var secondAction = "BEERS EARNED";
            var thirdAction = "INSTRUCTIONS";
            var fourthAction = "QUIT";
            MenuDraw(firstAction, secondAction, thirdAction, fourthAction);
        }

        //Gives the MenuDraw method the properties needed to draw an Action Menu for the current hero.
        public static void ActionsMenu(Hero player)
        {
            var firstAction = player.Actions[0].ToString();
            var secondAction = player.Actions[1].ToString();
            var thirdAction = player.Actions[2].ToString();
            var fourthAction = player.Actions[3].ToString();
            MenuDraw(firstAction, secondAction, thirdAction, fourthAction);
        }
    }
}
