using System.Collections.Generic;

namespace Battle4Beers.Client.Models
{
    public class ShadowPriest : Priest
    {
        public ShadowPriest(string name, int health, int healthRegen, List<Action> actions, int armor, int mana, int manaRegen, int spellPower) : base(name, health, healthRegen, actions, armor, mana, manaRegen, spellPower)
        {
        }
    }
}
