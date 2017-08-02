using System;
using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Utilities.Constants;

namespace Battle4Beers.Client.Models.Actions.PriestActions.HolyPriest
{
    public class Renew : Action, IBuff
    {
        private int heal;
        private int duration;

        public Renew(string name, int coolDown, int cost, int heal, int duration) : base(name, coolDown, cost)
        {
            this.Heal = heal;
            this.Duration = duration;
        }

        public int Heal
        {
            get { return this.heal; }
            protected set { this.heal = value; }
        }

        public int Duration
        {
            get
            {
                return this.duration;
            }
            protected set { this.duration = value; }
        }

        public override string ToString()
        {
            return $"{this.Name}: {Constants.HealingBuffString} {Constants.CooldownAndCost} Mana";
        }
    }
}
