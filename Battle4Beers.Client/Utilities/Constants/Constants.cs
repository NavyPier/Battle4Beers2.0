using System.Collections.Generic;

namespace Battle4Beers.Client.Utilities.Constants
{
    public class Constants
    {
        //01.Hero constants
        public const int HeroBaseArmor = 0;

        //01.1.Warrior

        #region WarriorConstants
        public static List<string> WarriorRoles = new List<string>() { "SWORDMASTER", "BERSERKER", "PROTECTOR" };
        public const int WarriorHealth = 2800;
        public const int WarriorDamage = 80;
        public const int WarriorHealtRegen = 70;
        public const int ProtectionWarriorArmor = 300;
        public const int WarriorStartingRage = 0;
        #endregion
        
        //01.2.Priest

        #region PriestConstants
        public static List<string> PriestRoles = new List<string>() {"HOLY PRIEST", "DISCIPLINE PRIEST", "SHADOW PRIEST"};
        public const int PriestHealth = 2100;
        public const int PriestMana = 2700;
        public const int PriestManaRegen = 110;
        public const int PriestSpellPower = 90;
        public const int PriestHealthRegen = 50;
        #endregion

        //01.3.Mage

        #region MageConstants
        public static List<string> MageRoles = new List<string>() {"FIRE MAGE", "ARCANE MAGE", "FROST MAGE"};
        public const int MageHealth = 2200;
        public const int MageMana = 2500;
        public const int MageSpellPower = 100;
        public const int MageHealthRegen = 50;
        public const int MageManaRegen = 100;
        #endregion

        public const string instructionsText = "--- PLACEHOLDER SOMEONE WRITE THIS DOWN WHEN WE FINISH THE GAME MECHANICS ---";
        public const string pressEnterText = "--- PRESS ENTER TO CONTINUE ---";

        //02.Error messages.
        public const string InvalidPlayerNameSymbolsCount = @"- Player's name must be longer than 3 symbols!!!
- A player's name must be shorter than 16 symbols!!!";

        public const string NameCannotBeNull = "- Player's name cannot be empty";

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