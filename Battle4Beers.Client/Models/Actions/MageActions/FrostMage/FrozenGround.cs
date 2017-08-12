using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Utilities.Constants;
using System;

namespace Battle4Beers.Client.Models.Actions.FrostMage
{
    public class FrozenGround : Action, IAgressiveAction
    {
        private int damage;

        public FrozenGround(string name, int coolDown, int cost, int damage) : base(name, coolDown, cost)
        {
            this.Damage = damage;
            this.Type = "agressive";
        }

        public int Damage
        {
            get { return this.damage; }
            protected set { this.damage = value; }
        }

        public void ExecuteAgressiveAction(Hero player, Hero enemy)
        {
            
        }

        public override string ToString()
        {
            return $"{this.Name}: Damage the selected opponent for {this.Damage} damage for the next {AbilityDurationConstants.FrozenGroundDuration} turns. Stun target for {AbilityDurationConstants.FrozenGroundDuration} turns. Cooldown: {this.CoolDown}, Cost: {this.Cost} Mana";
        }
    }
}
