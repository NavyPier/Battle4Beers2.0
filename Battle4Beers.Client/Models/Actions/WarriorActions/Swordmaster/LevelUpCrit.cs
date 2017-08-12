namespace Battle4Beers.Client.Models.Actions.WarriorActions.Swordmaster
{
    public class LevelUpCrit :  Action
    {
        public LevelUpCrit(string name, int coolDown, int cost) : base(name, coolDown, cost)
        {
            this.Type = "passive";
        }

        public override string ToString()
        {
            return "Level up a 35% chance of Critical strike for double damage for the rest of the game.".ToUpper();
        }
    }
}
