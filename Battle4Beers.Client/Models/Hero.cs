﻿using System;
using System.Collections.Generic;
using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Utilities.Constants;

namespace Battle4Beers.Client.Models
{
    public abstract class Hero : IHero
    {
        private string name;
        private int health;
        private List<Action> actions;

        public Hero(string name, int health)
        {
            this.Name = name;
            this.Health = health;
            this.actions = new List<Action>();
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
    }
}