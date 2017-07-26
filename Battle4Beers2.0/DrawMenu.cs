using System;

public class DrawMenu
{
    //Constant of the game title.
    public const string GameTitle = @"          _________       ___     ___  _________
          |   ___  |     |   |   |   | |   ___  |
          |  |___| |     |   |   |   | |  |___| |
          |________|__   |   |___|   | |________|__
          |  ______    | |_______    | |  ______    |
          |  |     |   |         |   | |  |     |   |
          |  |_____|   |         |   | |  |_____|   |
          |____________|         |___| |____________|";
    public static void Menu(string firstAction, string secondAction, string thirdAction, string fourthAction)
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

            Console.WriteLine(GameTitle);

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
                    Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (fourthAction.Length / 2)) + "}", "-> " + fourthAction); break;
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

        switch (counter)
        {
            case 1:
            case 2:
            case 3:
            case 4:
                return;
        }
    }

    //This method creates the starting menu for the game.
    public static void StartMenu()
    {
        var firstAction = "NEW GAME";
        var secondAction = "BEERS EARNED";
        var thirdAction = "INSTRUCTIONS";
        var fourthAction = "QUIT";
        Menu(firstAction, secondAction, thirdAction, fourthAction);
    }

    public static void ActionsMenu(Hero player)
    {
        var firstAction = player.Actions[0].ToString();
        var secondAction = player.Actions[1].ToString();
        var thirdAction = player.Actions[2].ToString();
        var fourthAction = player.Actions[3].ToString();
        Menu(firstAction, secondAction, thirdAction, fourthAction);
    }
}
