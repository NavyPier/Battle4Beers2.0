namespace Battle4Beers.Client.Interfaces
{
    public interface IDebuff : IAction
    {
        int Duration { get; }
    }
}
