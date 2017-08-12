using Battle4Beers.Client.Models;

namespace Battle4Beers.Client.Interfaces
{
    public interface IExecution
    {
        bool IsExecutionPossible(Hero player);
    }
}
