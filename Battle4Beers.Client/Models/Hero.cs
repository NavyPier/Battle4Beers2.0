using Battle4Beers.Client.Interfaces;
using System.Collections.Generic;

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
        private int stunnedDuration;

        protected Hero(string name, int health, int healthRegen, List<Action> actions, int armor)
        {
            this.Name = name;
            this.Health = health;
            this.HealthRegen = healthRegen;
            this.Armor = armor;
            this.actions = new List<Action>(actions);
            this.StunnedDuration = 0;
            this.Buffs = new List<Buff>();
            this.Debuffs = new List<Debuff>();
        }

        public int StunnedDuration
        {
            get { return this.stunnedDuration; }
            set { this.stunnedDuration = value; }
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

        public abstract void ExecuteAction(int cost);

        public virtual void TakeDamage(int amount)
        {
            if(this.Armor <= amount)
            {
                amount -= this.Armor;
                this.Health -= amount;
                this.Armor = 0;
            }
            else if(this.Armor > amount)
            {
                this.Armor -= amount;
            }
        }

        public void GetHealed(int amount)
        {
            this.Health += amount;
        }

        public void GainArmor(int amount)
        {
            this.Armor += amount;
        }

        public abstract void Regenerate();

        public override string ToString()
        {
            return $"{this.Name}: HEALTH: {this.Health} ARMOR: {this.Armor}";
        }
    }
}
