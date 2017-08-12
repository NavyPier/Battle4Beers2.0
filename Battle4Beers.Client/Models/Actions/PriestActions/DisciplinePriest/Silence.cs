using Battle4Beers.Client.Utilities.Constants;
using System;

namespace Battle4Beers.Client.Models.Actions.PriestActions.DisciplinePriest
{
    public class Silence : Action
    {
        public Silence(string name, int coolDown, int cost) : base(name, coolDown, cost)
        {
            this.Type = "agressive";
        }

        public override string ToString()
        {
            return $"Silence: Disables the target from casting any spells or actions for {AbilityDurationConstants.SilenceDuration} turns Cooldown: {this.CoolDown}, Cost: {this.Cost} Mana";
        }
    }
}
