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
            else if (action == MenuActions.ARCANE.ToString() || action == MenuActions.FIRE.ToString() || action == MenuActions.FROST.ToString())
            {
                CharacterCreation.CreateMage(action);
            }
            else if (action == MenuActions.DISCIPLINE.ToString() || action == MenuActions.HOLY.ToString() || action == MenuActions.SHADOW.ToString())
            {
                CharacterCreation.CreatePriest(action);
            }
            else if (action == MenuActions.BERSERKER.ToString() || action == MenuActions.SWORDMASTER.ToString() || action == MenuActions.PROTECTOR.ToString())
            {
                CharacterCreation.CreateWarrior(action);
            }
        }
    }
}
