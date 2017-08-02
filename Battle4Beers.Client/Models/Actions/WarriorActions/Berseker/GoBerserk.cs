namespace Battle4Beers.Client.Models.Actions.WarriorActions.Berseker
{
    using Interfaces;
    using Utilities.Constants;

    public class GoBerserk : Action, IBuff
    {
        private int duration;
        private int percentage;

        public GoBerserk(string name, int coolDown, int cost, int percentage, int duration) : base(name, coolDown, cost)
        {
            this.Duration = duration;
            this.Percentage = 100;
        }

        public int Percentage
        {
            get { return this.percentage; }
            protected set { this.percentage = value; }
        }

        public int Duration
        {
            get { return this.duration; }
            protected set { this.duration = value; }
        }

        public override string ToString()
        {
            return $"{this.Name}: Makes the player deal {this.Percentage}% more damage for the next {this.Duration}turns.Cooldown: {this.CoolDown}, Cost: {this.Cost} HP";
        }

    }
}
