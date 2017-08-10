using System;
using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Utilities.Constants;

namespace Battle4Beers.Client.Models.Actions
{
    public class Polymorph : Debuff
    {
        public Polymorph(string name, int coolDown, int cost, int duration) : base(name, coolDown, cost, duration)
        {
        }

        public override void DebuffPlayer(Hero player)
        {
            this.Duration--;
        }

        public override string ToString()
        {
            return $"{this.Name}: Stun target for {this.Duration} turns. Cooldown: {this.CoolDown}, Cost: {this.Cost}";
        }
    }
}
