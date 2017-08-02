using System;
using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Utilities.Constants;

namespace Battle4Beers.Client.Models.Actions.PriestActions.ShadowPriest
{
    public class CurseOfDeath : Action, IBuff
    {
        private int damageOverTime;
        private int duration;

        public CurseOfDeath(string name, int coolDown, int cost, int damageOverTime, int duration) : base(name, coolDown, cost)
        {
            this.DamageOverTime = damageOverTime;
            this.Duration = duration;
        }

        public int DamageOverTime
        {
            get { return this.damageOverTime; }
            protected set { this.damageOverTime = value; }
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
            return $"{this.Name}: {Constants.DamageOverTimeString} {Constants.CooldownAndCost} Mana";
        }
    }
}
