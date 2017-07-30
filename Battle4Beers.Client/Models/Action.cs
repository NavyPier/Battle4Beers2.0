using Battle4Beers.Client.Interfaces;

namespace Battle4Beers.Client.Models
{
    public abstract class Action : IAction
    {
        private string name;
        private int coolDown;

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

        public abstract override string ToString();
    }
}
