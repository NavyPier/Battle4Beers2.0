using System;
using Battle4Beers.Client.Interfaces;

namespace Battle4Beers.Client.Models
{
    public abstract class Action : IAction
    {
        private string name;
        private int coolDown;
        private int cost;
        private string type;

        public Action(string name, int coolDown, int cost)
        {
            this.Name = name;
            this.CoolDown = coolDown;
            this.Cost = cost;
        }

        public int CoolDown
        {
            get
            {
                return this.coolDown;
            }
            protected set
            {
                this.coolDown = value;
            }
        }

        public string Name
        {
            get { return this.name; }
            protected set { this.name = value; }
        }

        public int Cost
        {
            get
            {
                return this.cost;
            }
            protected set
            {
                this.cost = value;
            }
        }

        public string Type
        {
            get
            {
                return this.type;
            }
            set { this.type = value; }
        }

        public void ReduceCooldown()
        {
            this.CoolDown--;
        }

        public void SetCooldown(int coolDown)
        {
            this.CoolDown = coolDown;
        }

        public abstract override string ToString();
    }
}
