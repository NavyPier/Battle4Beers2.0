﻿using System;

namespace Battle4Beers.Client.Models.Actions.FireMage
{
    public class FireBlast : Action
    {
        private int damage;

        public FireBlast(string name, int coolDown, int cost, int damage) : base(name, coolDown, cost)
        {
            this.Damage = damage;
        }

        public int Damage
        {
            get { return this.damage; }
            protected set { this.damage = value; }
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}