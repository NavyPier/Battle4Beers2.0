namespace Battle4Beers.Client.Interfaces
{
    public interface ICaster : IHero
    {
        int Mana { get; }
        int SpellPower { get; }
        int ManaRegen { get; }
    }
}
