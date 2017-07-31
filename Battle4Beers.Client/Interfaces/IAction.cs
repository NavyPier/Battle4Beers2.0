namespace Battle4Beers.Client.Interfaces
{
    public interface IAction
    {
        string Name { get; }
        int CoolDown { get; }
        int Cost { get; }
    }
}
