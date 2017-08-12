using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Utilities.Constants;
using System;
using System.Linq;

namespace Battle4Beers.Client.Models.Actions.PriestActions.HolyPriest
{
    public class Serenity : Action, IFriendlyAction
    {
        private int heal;

        public Serenity(string name, int coolDown, int cost, int heal) : base(name, coolDown, cost)
        {
            this.Heal = heal;
            this.Type = "friendly";
        }

        public int Heal
        {
            get { return this.heal; }
            protected set { this.heal = value; }
        }

        public void DoFriendlyAction(Hero player, Hero ally)
        {
            ally.GetHealed(this.Heal);
            player.Actions.Where(a => a.Name == this.Name).First().SetCooldown(AbilityCooldownConstants.SerenityCooldown);
        }

        public override string ToString()
        {
            return $"{this.Name}: Heal target ally for {this.Heal}. Cooldown: {this.CoolDown}, Cost: {this.Cost} Mana";
        }
    }
}
