using Battle4Beers.Client.Utilities.Constants;

namespace Battle4Beers.Client.Models.Actions.PriestActions.DisciplinePriest
{
    public class Shield : Action
    {
        private double shieldRatio;

        public Shield(string name, int coolDown, int cost, double shieldRatio) : base(name, coolDown, cost)
        {
            this.ShieldRatio = shieldRatio;
            this.Type = "passive";
        }

        public double ShieldRatio
        {
            get { return this.shieldRatio; }
            protected set { this.shieldRatio = value; }
        }

        public override string ToString()
        {
            return $"{this.Name}: Buff target ally to receive only {this.ShieldRatio}% damage for the next {AbilityDurationConstants.ShieldDuration} turns Cooldown: {this.CoolDown}, Cost: {this.Cost} Mana";
        }

    }
}
