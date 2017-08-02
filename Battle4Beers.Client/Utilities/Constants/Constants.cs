namespace Battle4Beers.Client.Utilities.Constants
{
    public class Constants
    {
        //01.Hero constants
        public const int HeroBaseArmor = 0;

        //01.1.Warrior

        #region WarriorConstants

        public const int WarriorHealt = 2800;
        public const int WarriorDamage = 80;
        public const int WarriorHealtRegen = 70;
        public const int ProtectionWarriorArmor = 300;
        #endregion
        
        //01.2.Priest

        #region PriestConstants

        public const int PriestHealt = 2100;
        public const int PriestMana = 2700;
        public const int PriestManaRegen = 110;
        public const int PriestSpellPower = 90;
        public const int PriestHealtRegen = 50;
        #endregion

        //01.3.Mage

        #region MageConstants

        public const int MageHealt = 2200;
        public const int MageMana = 2500;
        public const int MageSpellPower = 100;
        public const int MageHealtRegen = 50;
        public const int MageManaRegen = 100;
        #endregion

        //Cooldown and Cost string

        public const string CooldownAndCost = "Cooldown: {this.CoolDown}, Cost: {this.Cost}";

        //Heal string constant strings

        public const string HealingBuffString = "Heal target ally for {this.Heal} for the next {this.Duration} turns.";
        public const string HealingString = "Heal target ally for {this.Heal}.";

        //Damaging spells constant strings
        
        public const string InstantDamageString = "Damage the selected opponent for {this.Damage} damage.";
        public const string DamageOverTimeString = "Damage the selected opponent for {this.Damage} damage for the next {this.Duration} turns.";

        //Stun string

        public const string StunString = "Stun target for {this.Duration} turns.";

        //Armor and shields strings

        public const string GiveArmorString = "Give {this.Armor} to target.";
        public const string DamageReductionString = "Buff target ally to receive only {this.Percentage}% damage for the next {this.Duration} turns";

        //Damage amplifier string

        public const string DamageAmplifierString = "Makes the player deal {this.Percentage}% more damage for the next {this.Duration} turns.";

        //02.Error messages.
        public const string InvalidPlayerNameSymbolsCount = @"- A player's name must be longer than 3 symbols!!!
                                                        - A player's name must be shorter than 16 symbols!!!";

        public const string NameCannotBeNull = "- Invalid player's name";

        //03.Drawing constants
        public const string GameTitle = @"          _________       ___     ___  _________
          |   ___  |     |   |   |   | |   ___  |
          |  |___| |     |   |   |   | |  |___| |
          |________|__   |   |___|   | |________|__
          |  ______    | |_______    | |  ______    |
          |  |     |   |         |   | |  |     |   |
          |  |_____|   |         |   | |  |_____|   |
          |____________|         |___| |____________|";        
    }
}