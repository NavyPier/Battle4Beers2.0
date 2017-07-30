namespace Battle4Beers.Client.Models
{
    public class ArcaneMage : Mage
    {
        public ArcaneMage(string name, int health, int mana, int spellPower) : base(name, health)
        {
            this.Mana = mana;
            this.SpellPower = spellPower;
        }
    }
}
