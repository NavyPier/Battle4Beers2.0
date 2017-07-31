using System;
using System.Collections.Generic;
using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Utilities.Constants;

namespace Battle4Beers.Client.Models
{
    public abstract class Hero : IHero
    {
        private string name;
        private int health;
        private int healthRegen;
        private int armor;
        public List<Action> actions;
        public List<Buff> buffs;
        
        public Hero(string name, int health, int healthRegen, List<Action> actions, int armor)
        {
            this.Name = name;
            this.Health = health;
            this.HealthRegen = healthRegen;
            this.Armor = armor;
            this.actions = new List<Action>(actions);
            this.buffs = new List<Buff>();
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
                if(value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException(Constants.InvalidPlayerNameSymbolsCount);
                }
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(Constants.NameCannotBeNull);
                }

                this.name = value;
            }
        }

        public List<Action> Actions
        {
            get
            {
                return this.actions;
            }
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
    }
}
