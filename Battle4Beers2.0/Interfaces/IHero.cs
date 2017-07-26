using System.Collections.Generic;

public interface IHero
{
    string Name { get; }
    int Health { get; }
    List<Action> Actions { get; }
}
