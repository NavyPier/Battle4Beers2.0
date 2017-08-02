using Battle4Beers.Client.Utilities.Constants;
using System;

namespace Battle4Beers.Client.Models.Actions.PriestActions.DisciplinePriest
{
    public class PurgeTheWicked : Action
    {
        private int damage;

        public PurgeTheWicked(string name, int coolDown, int cost, int damage) : base(name, coolDown, cost)
        {
            this.Damage = damage;
        }

        public int Damage
        {
            get { return this.damage; }
            protected set { this.damage = value; }
        }

        public override string ToString()
        {
            return $"{this.Name}: {Constants.InstantDamageString} {Constants.CooldownAndCost} Mana";
        }
    }
}
