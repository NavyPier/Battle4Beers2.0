using System;
using Battle4Beers.Client.Interfaces;
using System.Collections.Generic;
using Battle4Beers.Client.Utilities.Constants;

namespace Battle4Beers.Client.Models
{
    public abstract class Warrior : Hero, IFighter
    {
        private int rage;
        private int attackPower;

        public Warrior(string name, int health, int healthRegen, List<Action> actions, int armor, int rage, int attackPower) : base(name, health, healthRegen, actions, armor)
        {
            this.Rage = rage;
            this.AttackPower = attackPower;
        }

        public int AttackPower
        {
            get { return this.attackPower; }
            protected set { this.attackPower = value; }
        }

        public int Rage
        {
            get
            {
                return this.rage;
            }
            protected set
            {
                this.rage = value;
            }
        }

        public override void ExecuteAction(int cost)
        {
            this.Rage -= cost;
        }

        public override void Regenerate()
        {
            if (this.Health + Constants.WarriorHealthRegen < Constants.WarriorHealth)
            {
                this.Health += Constants.WarriorHealthRegen;
            }
            else
            {
                this.Health = Constants.WarriorHealth;
            }
        }

        public void GetRageOnHit()
        {
            if (this.Rage + Constants.WarriorRageOnHit > 100)
            {
                this.Rage = 100;
            }
            else
            {
                this.Rage += Constants.WarriorRageOnHit;
            }
        }
    }
}
