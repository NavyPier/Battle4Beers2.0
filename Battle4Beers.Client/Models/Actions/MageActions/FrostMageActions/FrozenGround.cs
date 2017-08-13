using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Utilities.Constants;
using System.Linq;

namespace Battle4Beers.Client.Models.Actions
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
            FrostMage mage = (FrostMage)player;
            enemy.StunnedDuration += AbilityDurationConstants.FrozenGroundDuration;
            if (mage.IcyVeins)
            {
                enemy.TakeDamage((int)(this.Damage * 1.5));
                mage.IcyVeinsDuration--;
            }
            else
            {
                enemy.TakeDamage(this.Damage);
            }

            if(mage.IcyVeinsDuration <= 0)
            {
                mage.IcyVeins = false;
            }

            player.Actions.Where(a => a.Name == this.Name).First().SetCooldown(AbilityCooldownConstants.FrozenGroundCooldown);
        }

        public override string ToString()
        {
            return $"{this.Name}: Damage the selected opponent for {this.Damage} damage. Stun target for {AbilityDurationConstants.FrozenGroundDuration} turns. Cooldown: {this.CoolDown}, Cost: {this.Cost} Mana";
        }
    }
}
