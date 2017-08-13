using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Utilities.Constants;
using System.Linq;

namespace Battle4Beers.Client.Models.Actions.WarriorActions
{
    public class ArmorUp : Action, IFriendlyAction
    {
        private int armor;

        public ArmorUp(string name, int coolDown, int cost, int armor) : base(name, coolDown, cost)
        {
            this.Armor = armor;
            this.Type = "friendly";
        }

        public int Armor
        {
            get { return this.armor; }
            set { this.armor = value; }
        }

        public void DoFriendlyAction(Hero player, Hero ally)
        {
            ally.GainArmor(this.Armor);
            player.Actions.Where(a => a.Name == this.Name).First().SetCooldown(AbilityCooldownConstants.ArmorUpCooldown);
        }

        public override string ToString()
        {
            return $"{this.Name}: Give {this.Armor} to target. Cooldown: {this.CoolDown}, Cost: {this.Cost} Rage";
        }
    }
}
