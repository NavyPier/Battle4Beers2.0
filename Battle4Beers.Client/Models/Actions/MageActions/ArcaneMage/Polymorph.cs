using System;
using Battle4Beers.Client.Interfaces;

namespace Battle4Beers.Client.Models.Actions
{
    public class Polymorph : Action, IBuff
    {
        private int duration;

        public Polymorph(string name, int coolDown, int cost, int duration) : base(name, coolDown, cost)
        {
            this.Duration = duration;
        }

        public int Duration
        {
            get
            {
                return this.duration;
            }
            protected set
            {
                this.duration = value;
            }
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
