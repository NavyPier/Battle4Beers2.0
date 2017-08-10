using System;

namespace Battle4Beers.Client.Models.Actions.PriestActions.DisciplinePriest
{
    public class Silence : Debuff
    {
        public Silence(string name, int coolDown, int cost, int duration) : base(name, coolDown, cost, duration)
        {
        }

        public override void DebuffPlayer(Hero player)
        {
        }

        public override string ToString()
        {
            return $"Silence: Disables the target from casting any spells or actions for {this.Duration} turns Cooldown: {this.CoolDown}, Cost: {this.Cost} Mana";
        }
    }
}
