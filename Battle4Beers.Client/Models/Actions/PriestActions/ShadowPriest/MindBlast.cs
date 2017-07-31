using System;

namespace Battle4Beers.Client.Models.Actions.PriestActions.ShadowPriest
{
    public class MindBlast : Action
    {
        private int damage;

        public MindBlast(string name, int coolDown, int cost) : base(name, coolDown, cost)
        {
            this.Damage = damage;
        }

        public int Damage
        {
            get { return this.damage; }
            protected set { this.damage = value; }
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
