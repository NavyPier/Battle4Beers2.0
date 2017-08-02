using Battle4Beers.Client.Utilities.Constants;
using System;

namespace Battle4Beers.Client.Models.Actions.PriestActions
{
    public class FlashHeal : Action
    {
        private int heal;

        public FlashHeal(string name, int coolDown, int cost, int heal) : base(name, coolDown, cost)
        {
            this.Heal = heal;
        }

        public int Heal
        {
            get { return this.heal; }
            protected set { this.heal = value; }
        }

        public override string ToString()
        {
            return $"{this.Name}: Heal target ally for {this.Heal}. Cooldown: {this.CoolDown}, Cost: {this.Cost} Mana";
        }
    }
}
