﻿using System;
using Battle4Beers.Client.Interfaces;

namespace Battle4Beers.Client.Models
{
    public abstract class Warrior : Hero, IHero, IFighter
    {
        private int rage;
        private int attackPower;

        public Warrior(string name, int health, int rage, int attackPower) : base(name, health)
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
    }
}
