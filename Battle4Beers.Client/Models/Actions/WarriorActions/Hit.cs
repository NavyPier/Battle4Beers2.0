using Battle4Beers.Client.Utilities.Constants;
using System;

namespace Battle4Beers.Client.Models.Actions.WarriorActions
{
    public class Hit : Action
    {
        private int rageGeneration;

        public Hit(string name, int coolDown, int cost) : base(name, coolDown, cost)
        {
            this.RageGeneration = 20;
        }

        public int RageGeneration
        {
            get { return this.rageGeneration; }
            protected set { this.rageGeneration = value; }
        }

        public override string ToString()
        {
            return $"{this.Name}: {Constants.InstantDamageString} Generate {this.rageGeneration} rage.";
        }
    }
}
