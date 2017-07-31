using System;
using Battle4Beers.Client.Interfaces;

namespace Battle4Beers.Client.Models.Actions.FrostMage
{
    public class FrostArmor : Action, IBuff
    {
        private int armor;
        private int duration;

        public FrostArmor(string name, int coolDown, int cost, int armor, int duration) : base(name, coolDown, cost)
        {
            this.Armor = armor;
        }

        public int Armor
        {
            get
            {
                return this.armor;
            }
            protected set
            {
                this.armor = value;
            }
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
