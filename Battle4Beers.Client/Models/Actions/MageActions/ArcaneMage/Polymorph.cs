using System;
using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Utilities.Constants;
using System.Linq;

namespace Battle4Beers.Client.Models.Actions
{
    public class Polymorph : Action, IAgressiveAction
    {
        public Polymorph(string name, int coolDown, int cost) : base(name, coolDown, cost)
        {
            this.Type = "agressive";
        }

        public int Damage
        {
            get;
        }

        public void ExecuteAgressiveAction(Hero player, Hero enemy)
        {
            enemy.StunnedDuration += AbilityDurationConstants.PolymorphDuration;
            player.Actions.Where(a => a.Name == this.Name).First().SetCooldown(AbilityCooldownConstants.PolymorphCooldown);

            ArcaneMage mage = (ArcaneMage)player;
            mage.PassiveDuration--;
            if (mage.PassiveDuration <= 0)
            {
                mage.IsAmplified = false;
            }
        }

        public override string ToString()
        {
            return $"{this.Name}: Stun target for {AbilityDurationConstants.PolymorphDuration} turns. Cooldown: {this.CoolDown}, Cost: {this.Cost}";
        }
    }
}
