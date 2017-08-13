using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Utilities.Constants;
using System.Linq;

namespace Battle4Beers.Client.Models.Actions
{
    public class CurseOfDeath : Debuff, IDebuff
    {
        private int damage;

        public CurseOfDeath(string name, int coolDown, int cost, int duration, int damage) : base(name, coolDown, cost, duration)
        {
            this.Damage = damage;
            this.Type = "debuff";
        }

        public int Damage
        {
            get { return this.damage; }
            protected set { this.damage = value; }
        }

        public override void DebuffPlayer(Hero player)
        {
            player.TakeDamage(this.Damage);
            player.Debuffs.Where(a => a.Name == this.Name && a.Duration == this.Duration).First().ReduceDuration(player);
        }

        public override void GivePlayerDebuff(Debuff debuff, Hero player, Hero enemy)
        {
            ShadowPriest playerOnTurn = (ShadowPriest)player;
            if (playerOnTurn.Sadist)
            {
                enemy.Debuffs.Add(new CurseOfDeath("CURSE OF DEATH", 0, 0, AbilityDurationConstants.CurseOfDeathDuration, (int)(this.Damage * 1.5)));
            }
            else
            {
                enemy.Debuffs.Add(new CurseOfDeath("CURSE OF DEATH", 0, 0, AbilityDurationConstants.CurseOfDeathDuration, this.Damage));
            }
            player.Actions.Where(a => a.Name == this.Name).First().SetCooldown(AbilityCooldownConstants.CurseOfDeathCooldown);
        }

        public override string ToString()
        {
            return $"{this.Name}: Damage the selected opponent for {this.Damage} damage for the next {this.Duration} turns. Cooldown: {this.CoolDown}, Cost: {this.Cost} Mana";
        }
    }
}
