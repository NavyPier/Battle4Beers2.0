using Battle4Beers.Client.Models;
using Battle4Beers.Client.Utilities.Constants;
using System;
using System.Collections.Generic;

namespace Battle4Beers.Client
{
    public class CharacterCreation
    {
        public static Validator validator;

        public static void TypeNames(string action)
        {
            var counter = 0;
            if (action == MenuActions.DUEL.ToString())
            {
                counter = 2;
            }
            else if (action == MenuActions.ARENA.ToString())
            {
                counter = 4;
            }

            var playerNames = new List<string>();
            Console.Clear();
            Console.WriteLine(Constants.GameTitle);
            Console.WriteLine();
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine($"ENTER NAME FOR PLAYER{i + 1}");
                var name = Console.ReadLine();
                try
                {
                    validator = new Validator();
                    validator.NameValidator(name);
                    if(!playerNames.Contains(name))
                    {
                        playerNames.Add(name);
                    }
                    else
                    {
                        Console.WriteLine("Player's name must be unique!");
                        i--;
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                    i--;
                }
            }
            TypesOfMenu.HeroSelectMenu(playerNames);
        }

        public static void SelectHeroClass(Dictionary<string, string> playerNamesAndHeroes)
        {
            foreach(var player in playerNamesAndHeroes)
            {
                TypesOfMenu.HeroClassSelectMenu(player.Key, player.Value);
            }
        }
    }
}
