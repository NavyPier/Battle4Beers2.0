using System;
using Battle4Beers.Client.Interfaces;

namespace Battle4Beers.Client.Models
{
    public abstract class Debuff : Action, IDebuff
    {
        private int duration;

        public Debuff(string name, int coolDown, int cost, int duration) : base(name, coolDown, cost)
        {
            this.Duration = duration;
        }

        public int Duration
        {
            get
            {
                return this.duration;
            }
            protected set { this.duration = value; }
        }

        public abstract void DebuffPlayer(Hero player);

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
