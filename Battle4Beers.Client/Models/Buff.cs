using System;
using Battle4Beers.Client.Interfaces;
using System.Linq;

namespace Battle4Beers.Client.Models
{
    public abstract class Buff : Action, IBuff
    {
        private int duration;

        public Buff(string name, int coolDown, int cost, int duration) : base(name, coolDown, cost)
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

        public abstract void BuffPlayer(Hero player);

        public abstract void GivePlayerBuff(Buff buff, Hero player);

        public void ReduceDuration(Hero player)
        {
            this.Duration--;
            if (this.Duration <= 0)
            {
                var buffToRemove = player.Buffs.Where(a => a.Name == this.Name && a.Duration <= 0).First();
                player.Buffs.Remove(buffToRemove);
            }
        }

        public abstract override string ToString();
    }
}
