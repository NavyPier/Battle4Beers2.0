using System;

namespace Battle4Beers.Client.Models.Actions.PriestActions.HolyPriest
{
    public class Renew : Buff
    {
        private int heal;

        public Renew(string name, int coolDown, int cost, int duration, int heal) : base(name, coolDown, cost, duration)
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
            return $"{this.Name}: Heal target ally for {this.Heal} for the next {this.Duration} turns. Cooldown: {this.CoolDown}, Cost: {this.Cost} Mana";
        }

    }
}
