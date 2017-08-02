using System;
using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Utilities.Constants;

namespace Battle4Beers.Client.Models.Actions.PriestActions.DisciplinePriest
{
    public class Shield : Action, IBuff
    {
        private double shieldRatio;
        private int duration;

        public Shield(string name, int coolDown, int cost, double shieldRatio, int duration) : base(name, coolDown, cost)
        {
            this.ShieldRatio = shieldRatio;
            this.Duration = duration;
        }

        public int Duration
        {
            get
            {
                return this.duration;
            }
            protected set { this.duration = value; }
        }

        public double ShieldRatio
        {
            get { return this.shieldRatio; }
            protected set { this.shieldRatio = value; }
        }


        public override string ToString()
        {
            return $"{this.Name}: Buff target ally to receive only {this.ShieldRatio}% damage for the next {this.Duration} turns Cooldown: {this.CoolDown}, Cost: {this.Cost} Mana";
        }
    }
}
