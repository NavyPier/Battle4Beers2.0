namespace Battle4Beers.Client.Models.Actions.WarriorActions.Berseker
{
    using Interfaces;
    public class GoBerserk : Action, IBuff
    {
        private int duration;
        public GoBerserk(string name, int coolDown, int cost, int duration) : base(name, coolDown, cost)
        {
            this.Duration = duration;
        }

        public int Duration
        {
            get { return this.duration; }
            protected set { this.duration = value; }
        }

        public override string ToString()
        {
            throw new System.NotImplementedException();
        }

    }
}
