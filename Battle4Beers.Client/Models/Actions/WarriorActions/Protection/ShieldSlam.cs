using System;

namespace Battle4Beers.Client.Models.Actions.WarriorActions
{
    public class ShieldSlam : Debuff
    {
        private int damage;

        public ShieldSlam(string name, int coolDown, int cost, int duration, int damage) : base(name, coolDown, cost, duration)
        {
            this.Damage = damage;
        }

        public int Damage
        {
            get { return this.damage; }
            protected set { this.damage = value; }
        }

        public override void DebuffPlayer(Hero player)
        {
            player.GetDamaged(this.Damage);
        }

        public override string ToString()
        {
            return $"{this.Name}: Damage the selected opponent for {this.Damage} damage. Stun target for {this.Duration} turns. Cooldown: {this.CoolDown}, Cost: {this.Cost} Rage";
        }

    }
}
