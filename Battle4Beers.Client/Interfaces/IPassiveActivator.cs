using Battle4Beers.Client.Models;

namespace Battle4Beers.Client.Interfaces
{
    public interface IPassiveActivator
    {
        int PassiveDuration { get; }
        void ActivatePassive(string nameOfPassive, Hero player);
        void DeactivatePassive(string nameOfPassive);
    }
}
