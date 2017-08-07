using Battle4Beers.Client.Models;
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
            else if (action == MenuActions.DUEL.ToString() || action == MenuActions.ARENA.ToString())
            {
                CharacterCreation.TypeNames(action);
            }
        }
    }
}
