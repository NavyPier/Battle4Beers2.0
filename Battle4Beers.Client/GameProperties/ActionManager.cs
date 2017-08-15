using Battle4Beers.Client.Models;
using Battle4Beers.Client.Utilities.Constants;
using System;
using System.Collections.Generic;
using Battle4Beers.Data;
using Battle4Beers.Models;
using System.Linq;

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
                TypesOfMenu.Instructions(Constants.instructionsText.ToString(),Constants.pressEnterText.ToString());
                TypesOfMenu.StartMenu();
            }

            else if (action == MenuActions.BEERS.ToString())
            {
                Battle4BeersDbContext db = new Battle4BeersDbContext();
                var nameReader = Console.ReadLine();
                var player = db.Players.FirstOrDefault(p => p.Name == nameReader);
                if (player != null)
                {
                    foreach (var beer in player.BeersToBeTaken)
                    {
                        Console.WriteLine(beer.Loser.Name);
                    }
                }
                else
                {
                    Console.WriteLine("Player does not exist!");
                }
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

        
    }
}
