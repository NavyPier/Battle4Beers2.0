using System;

namespace Battle4Beers.Client.Models.Actions.FireMage
{
    public class FireArmor : Buff
    {
        private int burnDamage;
        private int armor;

        public FireArmor(string name, int coolDown, int cost, int duration, int damageOverTime, int armor) : base(name, coolDown, cost, duration)
        {
            this.BurnDamage = damageOverTime;
            this.Armor = armor;
        }

        public int BurnDamage
        {
            get { return this.burnDamage; }
            protected set { this.burnDamage = value; }
        }

        public int Armor
        {
            get { return this.armor; }
            protected set { this.armor = value; }
        }

        public override string ToString()
        {
            return $"{this.Name}: Give {this.Armor} armor to target. If anyone attacks the person with Fire Armor on, they get burned for {this.BurnDamage} damage. Cooldown: {this.CoolDown}, Cost: {this.Cost} Mana";
        }

        public void DamageEnemy(Hero enemy)
        {
            enemy.GetDamaged(this.BurnDamage);
        }
    }
}
