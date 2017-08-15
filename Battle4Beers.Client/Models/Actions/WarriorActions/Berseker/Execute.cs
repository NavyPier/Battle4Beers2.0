using Battle4Beers.Client.Interfaces;

namespace Battle4Beers.Client.Models.Actions.WarriorActions.Berseker
{
    public class Execute : Action, IExecution
    {
        private int damage;

        public Execute(string name, int coolDown, int cost, int damage) : base(name, coolDown, cost)
        {
            this.Damage = damage;
            this.Type = "execution";
        }

        public int Damage
        {
            get { return this.damage; }
            protected set { this.damage = value; }
        }

        public bool IsExecutionPossible(Hero player)
        {
            if (player.Health <= this.Damage)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public override string ToString()
        {
            return $"{this.Name}: Execute the target if his HP is below {this.damage}";
        }
    }
}
