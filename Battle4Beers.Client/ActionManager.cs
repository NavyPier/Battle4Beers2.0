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
            else if (action == MenuActions.ARCANE.ToString())
            {
            }
            else if (action == MenuActions.FROST.ToString())
            {
            }
            else if (action == MenuActions.FIRE.ToString())
            {
            }
            else if (action == MenuActions.DISCIPLINE.ToString())
            {
            }
            else if (action == MenuActions.SHADOW.ToString())
            {
            }
            else if (action == MenuActions.HOLY.ToString())
            {
            }
            else if (action == MenuActions.BERSERKER.ToString())
            {
            }
            else if (action == MenuActions.SWORDMASTER.ToString())
            {
            }
            else if (action == MenuActions.PROTECTOR.ToString())
            {
            }

        }

        public void StartGame()
        {
           
        }
    }
}
