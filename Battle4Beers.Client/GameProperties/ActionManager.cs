using Battle4Beers.Client.Models;
using Battle4Beers.Client.Utilities.Constants;
using System;
using System.Collections.Generic;
using Battle4Beers.Data;
using Battle4Beers.Models;
using System.Linq;
using System.Diagnostics;
using Battle4Beers.Client.GameProperties;

namespace Battle4Beers.Client
{
    public class ActionManager
    {
        public static List<Hero> players = new List<Hero>();

        public void DoAction(string action)
        {
            if (action == MenuActions.NEW.ToString())
            {
                TypesOfMenu.NewGameMenu();
            }
            else if (action == MenuActions.INSTRUCTIONS.ToString())
            {
                InstructionsWriter.WriteInstructions();
                TypesOfMenu.StartMenu();
            }

            else if (action == MenuActions.BEERS.ToString())
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ENTER PLAYER'S NAME TO RECEIVE HIS BEER EARNINGS:");
                Battle4BeersDbContext db = new Battle4BeersDbContext();
                var nameReader = Console.ReadLine();
                var player = db.Players.FirstOrDefault(p => p.Name == nameReader);
                var key = new ConsoleKeyInfo();
                while (key.Key != ConsoleKey.Enter)
                {
                    if (player != null)
                    {
                        var namesWithBeers = new SortedDictionary<string, int>();
                        foreach (var beer in player.BeersToBeTaken)
                        {
                            var loserName = beer.Loser.Name;
                            if (!namesWithBeers.ContainsKey(loserName))
                            {
                                namesWithBeers[loserName] = 0;
                            }
                            namesWithBeers[loserName]++;
                        }
                        if (namesWithBeers.Count > 0)
                        {
                            foreach (var nameWithBeers in namesWithBeers.Reverse())
                            {
                                if (nameWithBeers.Value <= 1)
                                {
                                    Console.WriteLine($"-----   {nameWithBeers.Key} owns {nameWithBeers.Value} beer   -----");
                                }
                                else
                                {
                                    Console.WriteLine($"-----   {nameWithBeers.Key} owns {nameWithBeers.Value} beers   -----");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Player has not earned any beers yet!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Player does not exist!");
                        Pause(3);
                    }
                    Console.WriteLine("...PRESS ENTER TO GO BACK TO MAIN MENU...");
                    key = Console.ReadKey();
                }
                TypesOfMenu.StartMenu();
            }

            //--> TERMINATES PROGRAM <--
            else if (action == MenuActions.QUIT.ToString())
            {
                Environment.Exit(0);
            }

            else if (action == MenuActions.DUEL.ToString() || action == MenuActions.ARENA.ToString())
            {
                CharacterCreation.TypeNames(action);
            }
        }
        public static void Pause(int sec)
        {
            Console.WriteLine();
            var pauseProc = Process.Start(
                new ProcessStartInfo()
                {
                    FileName = "cmd",
                    Arguments = "/C TIMEOUT /t " + sec + " /nobreak > NUL",
                    UseShellExecute = false
                });
            pauseProc.WaitForExit();
        }
    }
}
