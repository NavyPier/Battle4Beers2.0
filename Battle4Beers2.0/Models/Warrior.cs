public class Warrior : Hero
{
    private int armor;

    public Warrior(string name, int health) : base(name, health)
    {
    }

    public int Armor
    {
        get { return this.armor; }
        protected set { this.armor = value; }
    }
}
