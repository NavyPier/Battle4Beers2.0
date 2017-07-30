namespace Battle4Beers.Client.Models
{
    public class DisciplinePriest : Priest
    {
        public DisciplinePriest(string name, int health, int mana) : base(name, health)
        {
            this.Mana = mana;
        }
    }
}
