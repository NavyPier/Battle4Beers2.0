﻿using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Utilities.Constants;
using System;

namespace Battle4Beers.Client.Models.Actions.PriestActions.DisciplinePriest
{
    public class PurgeTheWicked : Action, IAgressiveAction
    {
        private int damage;

        public PurgeTheWicked(string name, int coolDown, int cost, int damage) : base(name, coolDown, cost)
        {
            this.Type = "agressive";
            this.Damage = damage;
        }

        public int Damage
        {
            get { return this.damage; }
            protected set { this.damage = value; }
        }

        public void ExecuteAgressiveAction(Hero player, Hero enemy)
        {
            enemy.GetDamaged(this.Damage);
        }

        public override string ToString()
        {
            return $"{this.Name}: Damage the selected opponent for {this.Damage} damage. Cooldown: {this.CoolDown}, Cost: {this.Cost} Mana";
        }
    }
}
