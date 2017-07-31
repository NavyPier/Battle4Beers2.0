﻿using System;

namespace Battle4Beers.Client.Models.Actions.PriestActions.HolyPriest
{
    public class HolyNova : Action
    {
        private int damage;
        private int heal;

        public HolyNova(string name, int coolDown, int cost, int damage, int heal) : base(name, coolDown, cost)
        {
            this.Damage = damage;
            this.Heal = heal;
        }

        public int Damage
        {
            get { return this.damage; }
            protected set { this.damage = value; }
        }

        public int Heal
        {
            get { return this.heal; }
            protected set { this.heal = value; }
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}