using System;
using Battle4Beers.Client.Interfaces;

namespace Battle4Beers.Client.Models
{
    public class Buff : IBuff
    {
        private int duration;

        public Buff(int duration)
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
    }
}
