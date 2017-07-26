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

    //This method creates the starting menu for the game.
    public static void StartMenu()
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
            string newGame = "NEW GAME";
            string beerEarnings = "BEERS EARNED";
            string instructionsText = "INSTRUCTIONS";
            string quit = "QUIT";

            switch (counter)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (newGame.Length / 2)) + "}", "-> " + newGame);
                    Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (beerEarnings.Length / 2)) + "}", beerEarnings);
                    Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (instructionsText.Length / 2)) + "}", instructionsText);
                    Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (quit.Length / 2)) + "}", quit); break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (newGame.Length / 2)) + "}", newGame);
                    Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (beerEarnings.Length / 2)) + "}", "-> " + beerEarnings);
                    Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (instructionsText.Length / 2)) + "}", instructionsText);
                    Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (quit.Length / 2)) + "}", quit); break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (newGame.Length / 2)) + "}", newGame);
                    Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (beerEarnings.Length / 2)) + "}", beerEarnings);
                    Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (instructionsText.Length / 2)) + "}", "-> " + instructionsText);
                    Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (quit.Length / 2)) + "}", quit); break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (newGame.Length / 2)) + "}", newGame);
                    Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (beerEarnings.Length / 2)) + "}", beerEarnings);
                    Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (instructionsText.Length / 2)) + "}", instructionsText);
                    Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (quit.Length / 2)) + "}", "-> " + quit); break;
                default:
                    if (counter == 5)
                    {
                        counter = 1;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (newGame.Length / 2)) + "}", "-> " + newGame);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (beerEarnings.Length / 2)) + "}", beerEarnings);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (instructionsText.Length / 2)) + "}", instructionsText);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (quit.Length / 2)) + "}", quit);
                    }
                    else if (counter == 0)
                    {
                        counter = 4;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (newGame.Length / 2)) + "}", newGame);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (beerEarnings.Length / 2)) + "}", beerEarnings);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (instructionsText.Length / 2)) + "}", instructionsText);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (quit.Length / 2)) + "}", "-> " + quit);
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

    public static void ActionsMenu(Hero player)
    {
    }
}
