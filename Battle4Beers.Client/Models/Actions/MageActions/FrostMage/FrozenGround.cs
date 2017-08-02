using System;
using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Utilities.Constants;

namespace Battle4Beers.Client.Models.Actions.FrostMage
{
    public class FrozenGround : Action, IBuff
    {
        private int damage;
        private int duration;

        public FrozenGround(string name, int coolDown, int cost, int damage, int duration) : base(name, coolDown, cost)
        {
            this.Damage = damage;
            this.Duration = duration;
        }

        public int Damage
        {
            get { return this.damage; }
            protected set { this.damage = value; }
        }

        public int Duration
        {
            get
            {
                return this.duration;
            }
            protected set
            {
                this.duration = value;
            }
        }

        public override string ToString()
        {
            return $"{this.Name}: {Constants.DamageOverTimeString} {Constants.StunString} {Constants.CooldownAndCost} Mana";
        }
    }
}
