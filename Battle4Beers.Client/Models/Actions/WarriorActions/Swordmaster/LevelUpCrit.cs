namespace Battle4Beers.Client.Models.Actions.WarriorActions.Swordmaster
{
    public class LevelUpCrit : Action
    {
        public LevelUpCrit(string name, int coolDown, int cost) : base(name, coolDown, cost)
        {
        }

        public override string ToString()
        {
            throw new System.NotImplementedException();
        }
    }
}
