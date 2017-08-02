using Battle4Beers.Client.Utilities.Constants;

namespace Battle4Beers.Client.Models.Actions.WarriorActions
{
    public class ArmorUp : Action
    {
        private int armor;
        public ArmorUp(string name, int coolDown, int cost, int armor) : base(name, coolDown, cost)
        {
            this.Armor = armor;
        }

        public int Armor
        {
            get { return this.armor; }
            set { this.armor = value; }
        }

        public override string ToString()
        {
            return $"{this.Name}: Give {this.Armor} to target. Cooldown: {this.CoolDown}, Cost: {this.Cost} Rage";
        }
    }
}
