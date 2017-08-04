using System;
using System.Collections.Generic;
using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Utilities.Constants;

namespace Battle4Beers.Client.Models
{
    public abstract class Hero : IHero, IBuffable
    {
        private string name;
        private int health;
        private int healthRegen;
        private int armor;
        public List<Action> actions;
        public List<Buff> buffs;
        public List<Debuff> debuffs;
        
        public Hero(string name, int health, int healthRegen, List<Action> actions, int armor)
        {
            this.Name = name;
            this.Health = health;
            this.HealthRegen = healthRegen;
            this.Armor = armor;
            this.actions = new List<Action>(actions);
            this.buffs = new List<Buff>();
            this.debuffs = new List<Debuff>();
        }

        public int Armor
        {
            get { return this.armor; }
            protected set { this.armor = value; }
        }

        public int Health
        {
            get { return this.health; }
            protected set { this.health = value; }
        }

        public string Name
        {
            get { return this.name; }
            protected set
            {
                this.name = value;
            }
        }

        public List<Action> Actions
        {
            get
            {
                return this.actions;
            }
            protected set { this.actions = value; }
        }

        public int HealthRegen
        {
            get
            {
                return this.healthRegen;
            }
            protected set
            {
                this.healthRegen = value;
            }
        }

        public List<Buff> Buffs
        {
            get
            {
                return this.buffs;
            }
            protected set { this.buffs = value; }
        }

        public List<Debuff> Debuffs
        {
            get
            {
                return this.debuffs;
            }
            protected set { this.debuffs = value; }
        }
    }
}
