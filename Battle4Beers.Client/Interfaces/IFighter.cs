namespace Battle4Beers.Client.Interfaces
{
    public interface IFighter : IHero
    {
        int Rage { get; }
        int AttackPower { get; }
    }
}
