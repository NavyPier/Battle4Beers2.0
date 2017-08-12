using System;
using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Utilities.Constants;
using System.Linq;

namespace Battle4Beers.Client.Models.Actions
{
    public class Polymorph : Action
    {
        public Polymorph(string name, int coolDown, int cost) : base(name, coolDown, cost)
        {
            this.Type = "agressive";
        }

        public void DoAgressiveAction(Hero player, Hero enemy)
        {
            enemy.StunnedDuration += AbilityDurationConstants.PolymorphDuration;
            player.Actions.Where(a => a.Name == this.Name).First().SetCooldown(AbilityCooldownConstants.PolymorphCooldown);
        }

        public override string ToString()
        {
            return $"{this.Name}: Stun target for {AbilityDurationConstants.PolymorphDuration} turns. Cooldown: {this.CoolDown}, Cost: {this.Cost}";
        }
    }
}
