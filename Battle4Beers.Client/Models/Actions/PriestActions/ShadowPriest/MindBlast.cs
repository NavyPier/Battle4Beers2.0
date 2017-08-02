using Battle4Beers.Client.Utilities.Constants;
using System;

namespace Battle4Beers.Client.Models.Actions.PriestActions.ShadowPriest
{
    public class MindBlast : Action
    {
        private int damage;

        public MindBlast(string name, int coolDown, int cost) : base(name, coolDown, cost)
        {
            this.Damage = damage;
        }

        public int Damage
        {
            get { return this.damage; }
            protected set { this.damage = value; }
        }

        public override string ToString()
        {
            return $"{this.Name}: Damage the selected opponent for {this.Damage} damage. Cooldown: {this.CoolDown}, Cost: {this.Cost} Mana";
        }
    }
}
