using System;
using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Utilities.Constants;

namespace Battle4Beers.Client.Models.Actions.PriestActions.DisciplinePriest
{
    public class Silence : Action, IBuff
    {
        private int duration;

        public Silence(string name, int coolDown, int cost, int duration) : base(name, coolDown, cost)
        {
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

        public override string ToString()
        {
            return $"Silence: Disables the target from casting any spells or actions for {this.duration} turns {Constants.CooldownAndCost} Mana";
        }
    }
}
