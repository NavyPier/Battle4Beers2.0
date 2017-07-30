namespace Battle4Beers.Client.Models
{
    public class HolyPriest : Priest
    {
        public HolyPriest(string name, int health, int mana) : base(name, health)
        {
            this.Mana = mana;
        }
    }
}
