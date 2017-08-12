using Battle4Beers.Client.Utilities.Constants;
using System;

namespace Battle4Beers.Client.Models.Actions.WarriorActions.Berseker
{
    public class GoBerserk : Action
    {
        private int percentage;

        public GoBerserk(string name, int coolDown, int cost, int percentage) : base(name, coolDown, cost)
        {
            this.Percentage = percentage;
            this.Type = "passive";
        }

        public int Percentage
        {
            get { return this.percentage; }
            protected set { this.percentage = value; }
        }

        public override string ToString()
        {
            return $"{this.Name}: Makes the player deal {this.Percentage}% more damage for the next {AbilityDurationConstants.BerserkDuration} turns.Cooldown: {this.CoolDown}, Cost: 200 HP";
        }

    }
}
