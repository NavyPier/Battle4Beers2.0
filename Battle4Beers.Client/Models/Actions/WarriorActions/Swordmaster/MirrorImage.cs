﻿using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Utilities.Constants;
using System;

namespace Battle4Beers.Client.Models.Actions.WarriorActions.Swordmaster
{
    public class MirrorImage : Action, IAgressiveAction
    {
        private int damage;

        public MirrorImage(string name, int coolDown, int cost, int damage) : base(name, coolDown, cost)
        {
            this.Damage = damage;
            this.Type = "agressive";
        }

        public int Damage
        {
            get { return this.damage; }
            protected set { this.damage = value; }
        }

        public void ExecuteAgressiveAction(Hero player, Hero enemy)
        {
            enemy.StunnedDuration++;
            SwordmasterWarrior playerOnTurn = (SwordmasterWarrior)player;
            if(playerOnTurn.CriticalStrike)
            {
                enemy.GetDamaged(this.Damage * 2);
            }
            else
            {
                enemy.GetDamaged(this.Damage);
            }
        }

        public override string ToString()
        {
            return $"{this.Name}: Damage the selected opponent for {this.Damage} damage. Stun target for {AbilityDurationConstants.MirrorImageDuration} turns. Cooldown: {this.CoolDown}, Cost: {this.Cost} Rage";
        }

    }
}
