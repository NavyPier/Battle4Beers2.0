using Battle4Beers.Client.Utilities.Constants;
using System;

namespace Battle4Beers.Client.Models.Actions.WarriorActions.Berseker
{
    public class GoBerserk : Buff
    {
        private int percentage;

        public GoBerserk(string name, int coolDown, int cost, int duration, int percentage) : base(name, coolDown, cost, duration)
        {
            this.Percentage = 100;
        }

        public int Percentage
        {
            get { return this.percentage; }
            protected set { this.percentage = value; }
        }

        public override string ToString()
        {
            return $"{this.Name}: Makes the player deal {this.Percentage}% more damage for the next {this.Duration}turns.Cooldown: {this.CoolDown}, Cost: {this.Cost} HP";
        }

    }
}
