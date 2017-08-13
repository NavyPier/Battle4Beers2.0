using Battle4Beers.Client.Interfaces;

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
        }

        public abstract override string ToString();
    }
}
