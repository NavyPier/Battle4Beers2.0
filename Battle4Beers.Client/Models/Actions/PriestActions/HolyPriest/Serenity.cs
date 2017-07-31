using System;

namespace Battle4Beers.Client.Models.Actions.PriestActions.HolyPriest
{
    public class Serenity : Action
    {
        private int heal;

        public Serenity(string name, int coolDown, int cost, int heal) : base(name, coolDown, cost)
        {
            this.Heal = heal;
        }

        public int Heal
        {
            get { return this.heal; }
            protected set { this.heal = value; }
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
