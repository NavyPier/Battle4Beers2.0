using Battle4Beers.Client.Models;
using Battle4Beers.Client.Utilities.Constants;
using System;
using System.Collections.Generic;

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
