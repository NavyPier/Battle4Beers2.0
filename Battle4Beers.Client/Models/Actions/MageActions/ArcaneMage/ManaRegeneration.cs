using System;

namespace Battle4Beers.Client.Models.Actions
{
    public class ManaRegeneration : Action
    {
        private int mana;

        public ManaRegeneration(string name, int coolDown, int cost, int mana) : base(name, coolDown, cost)
        {
            this.Mana = mana;
        }

        public int Mana
        {
            get { return this.mana; }
            protected set { this.mana = value; }
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
