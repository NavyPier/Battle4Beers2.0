using System;
using Battle4Beers.Client.Interfaces;

namespace Battle4Beers.Client.Models
{
    public abstract class Warrior : Hero, IHero, IFighter
    {
        private int rage;

        public Warrior(string name, int health, int rage) : base(name, health)
        {
            this.Rage = rage;
        }

        public int Rage
        {
            get
            {
                return this.rage;
            }
            protected set
            {
                this.rage = value;
            }
        }
    }
}
