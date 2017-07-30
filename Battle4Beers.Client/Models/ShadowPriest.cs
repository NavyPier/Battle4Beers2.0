namespace Battle4Beers.Client.Models
{
    public class ShadowPriest : Priest
    {
        public ShadowPriest(string name, int health, int mana) : base(name, health)
        {
            this.Mana = mana;
        }
    }
}
