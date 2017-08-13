using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Utilities.Constants;
using System.Linq;

namespace Battle4Beers.Client.Models.Actions.PriestActions.HolyPriest
{
    public class PunishTheUnholy : Action, IAgressiveAction
    {
        private int damage;

        public PunishTheUnholy(string name, int coolDown, int cost, int damage) : base(name, coolDown, cost)
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
            enemy.TakeDamage(this.Damage);
            player.Actions.Where(a => a.Name == this.Name).First().SetCooldown(AbilityCooldownConstants.PunishTheUnholyCooldown);
        }

        public override string ToString()
        {
            return $"{this.Name}: Damage your target by {this.damage}. Cooldown: {this.CoolDown}, Cost: {this.Cost} Mana";
        }
    }
}
