using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Utilities.Constants;
using System.Linq;

namespace Battle4Beers.Client.Models.Actions.WarriorActions
{
    public class ShieldSlam : Action, IAgressiveAction
    {
        private int damage;

        public ShieldSlam(string name, int coolDown, int cost, int damage) : base(name, coolDown, cost)
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
            enemy.StunnedDuration++;
            player.Actions.Where(a => a.Name == this.Name).First().SetCooldown(AbilityCooldownConstants.ShieldSlamCooldown);
            enemy.TakeDamage(this.Damage);
        }

        public override string ToString()
        {
            return $"{this.Name}: Damage the selected opponent for {this.Damage} damage. Stun target for {AbilityDurationConstants.ShieldSlamDuration} turns. Cooldown: {this.CoolDown}, Cost: {this.Cost} Rage";
        }

    }
}
