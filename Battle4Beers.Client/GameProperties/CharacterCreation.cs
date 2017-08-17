using Battle4Beers.Client.Models;
using Battle4Beers.Client.Models.Actions;
using Battle4Beers.Client.Models.Actions.PriestActions;
using Battle4Beers.Client.Models.Actions.PriestActions.DisciplinePriest;
using Battle4Beers.Client.Models.Actions.PriestActions.HolyPriest;
using Battle4Beers.Client.Models.Actions.PriestActions.ShadowPriest;
using Battle4Beers.Client.Models.Actions.WarriorActions;
using Battle4Beers.Client.Models.Actions.WarriorActions.Berseker;
using Battle4Beers.Client.Models.Actions.WarriorActions.Swordmaster;
using Battle4Beers.Client.Utilities.Constants;
using System;
using System.Collections.Generic;

namespace Battle4Beers.Client
{
    public class CharacterCreation
    {
        public static Validator validator;
        public static List<Hero> players = new List<Hero>();

        public static void TypeNames(string action)
        {
            var counter = 0;
            if (action == MenuActions.DUEL.ToString())
            {
                counter = 2;
            }
            else if (action == MenuActions.ARENA.ToString())
            {
                counter = 4;
            }

            var playerNames = new List<string>();
            Console.Clear();
            Console.WriteLine(Constants.GameTitle);
            Console.WriteLine();
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine($"ENTER NAME FOR PLAYER{i + 1}");
                var name = Console.ReadLine().Trim();
                try
                {
                    validator = new Validator();
                    validator.NameValidator(name);
                    if(!playerNames.Contains(name))
                    {
                        playerNames.Add(name);
                    }
                    else
                    {
                        Console.WriteLine("Player's name must be unique!");
                        i--;
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                    i--;
                }
            }
            TypesOfMenu.HeroSelectMenu(playerNames);
        }

        public static void SelectHeroClass(Dictionary<string, string> playerNamesAndHeroes)
        {
            Dictionary<string, string> tempDict = new Dictionary<string, string>();
            foreach(var player in playerNamesAndHeroes)
            {
                tempDict.Add(player.Key, TypesOfMenu.HeroClassSelectMenu(player.Key, player.Value));
            }

            foreach(var player in tempDict)
            {
                if(Constants.MageRoles.Contains(player.Value))
                {
                    CreateMage(player.Key, player.Value);
                }
                else if(Constants.WarriorRoles.Contains(player.Value))
                {
                    CreateWarrior(player.Key, player.Value);
                }
                else
                {
                    CreatePriest(player.Key, player.Value);
                }
            }
            playerNamesAndHeroes = tempDict;
            Combat.ArrangeTeams(players);
        }

        public static void CreateWarrior(string playerName, string typeOfWarrior)
        {
            List<Models.Action> actions = new List<Models.Action>();
            actions.Add(new Hit("HIT", Constants.BaseCooldown, Constants.BaseCost, Constants.WarriorDamage));
            if (typeOfWarrior == "SWORDMASTER")
            {
                actions.Add(new LevelUpCrit("LEVEL UP CRITICAL STRIKE", Constants.BaseCooldown, Constants.BaseCost));
                actions.Add(new MirrorImage("MIRROR IMAGE", Constants.BaseCooldown, 20, Constants.WarriorDamage));
                actions.Add(new WindFury("WINDFURY", Constants.BaseCooldown, 50, Constants.WarriorDamage * 4));
                Hero swordmaster = new SwordmasterWarrior(playerName, Constants.WarriorHealth, Constants.WarriorHealthRegen
                    , actions, Constants.HeroBaseArmor, Constants.WarriorStartingRage, Constants.WarriorDamage);
                players.Add(swordmaster);
            }
            else if(typeOfWarrior == "BERSERKER")
            {
                actions.Add(new GoBerserk("GO BERSERK", Constants.BaseCooldown, Constants.BaseCost, 100));
                actions.Add(new WildAxes("WILD AXES", Constants.BaseCooldown, 40, Constants.WarriorDamage * 3));
                actions.Add(new Execute("EXECUTE", Constants.BaseCooldown, 0, 700));
                Hero berserker = new BerserkerWarrior(playerName, Constants.WarriorHealth, Constants.WarriorHealthRegen
                    , actions, Constants.HeroBaseArmor, Constants.WarriorStartingRage, Constants.WarriorDamage);
                players.Add(berserker);
            }
            else
            {
                actions.Add(new ArmorUp("ARMOR UP", Constants.BaseCooldown, Constants.BaseCost, Constants.ProtectionWarriorArmor));
                actions.Add(new Hibernate("HIBERNATE", Constants.BaseCooldown, 40,  Constants.WarriorHealthRegen * 4));
                actions.Add(new ShieldSlam("SHIELD SLAM", Constants.BaseCooldown, 30, Constants.WarriorDamage * 4));
                Hero protector = new ProtectionWarrior(playerName, Constants.WarriorHealth, Constants.WarriorHealthRegen
                    , actions, Constants.ProtectionWarriorArmor, Constants.WarriorStartingRage, Constants.WarriorDamage);
                players.Add(protector);
            }
        }

        public static void CreateMage(string playerName, string typeOfMage)
        {
            List<Models.Action> actions = new List<Models.Action>();
            if (typeOfMage == "FIRE")
            {
                actions.Add(new FireBlast("FIRE BLAST", Constants.BaseCooldown, Constants.MageManaRegen, Constants.MageSpellPower));
                actions.Add(new FireArmor("ARMOR OF FIRE", Constants.BaseCooldown, 150, Constants.MageSpellPower, 400));
                actions.Add(new PyroBlast("PYROBLAST", Constants.BaseCooldown, 200, Constants.MageSpellPower * 5));
                actions.Add(new Incinerate("INCINERATE", Constants.BaseCooldown, 0,  800));
                Hero fireMage = new FireMage(playerName, Constants.MageHealth, Constants.MageHealthRegen
                    , actions, Constants.HeroBaseArmor, Constants.MageMana, Constants.MageManaRegen, Constants.MageSpellPower);
                players.Add(fireMage);
            }
            else if (typeOfMage == "ARCANE")
            {
                actions.Add(new ArcaneBlast("ARCANE BLAST", Constants.BaseCooldown, Constants.MageManaRegen, Constants.MageSpellPower));
                actions.Add(new AmplifyMagic("AMPLIFY MAGIC", Constants.BaseCooldown, 200));
                actions.Add(new Polymorph("POLYMORPH", Constants.BaseCooldown, 300));
                actions.Add(new ManaRegeneration("MANA REGENERATION", Constants.BaseCooldown, 0, Constants.MageManaRegen * 4));
                Hero arcaneMage = new ArcaneMage(playerName, Constants.MageHealth, Constants.MageHealthRegen
                    , actions, Constants.HeroBaseArmor, Constants.MageMana, Constants.MageManaRegen, Constants.MageSpellPower);
                players.Add(arcaneMage);
            }
            else
            {
                actions.Add(new FrostBolt("FROST BOLT", Constants.BaseCooldown, Constants.MageManaRegen, Constants.MageSpellPower));
                actions.Add(new FrostArmor("FROSTED ARMOR", Constants.BaseCooldown, 200, 200, 20));
                actions.Add(new IcyVeins("ICY VEINS", Constants.BaseCooldown, 300, 50));
                actions.Add(new FrozenGround("FROZEN GROUND", Constants.BaseCooldown, 400, Constants.MageSpellPower * 2));
                Hero frostMage = new FrostMage(playerName, Constants.MageHealth, Constants.MageHealthRegen
                    , actions, Constants.HeroBaseArmor, Constants.MageMana, Constants.MageManaRegen, Constants.MageSpellPower);
                players.Add(frostMage);
            }
        }

        public static void CreatePriest(string playerName, string typeOfPriest)
        {
            List<Models.Action> actions = new List<Models.Action>();
            actions.Add(new FlashHeal("FLASH HEAL", Constants.BaseCooldown, Constants.PriestManaRegen, Constants.PriestSpellPower));
            if (typeOfPriest == "HOLY")
            {
                actions.Add(new Renew("RENEW", Constants.BaseCooldown, 200, 2, (int)(Constants.PriestSpellPower * 1.5)));
                actions.Add(new Serenity("SERENITY", Constants.BaseCooldown, 400, Constants.PriestSpellPower * 5));
                actions.Add(new PunishTheUnholy("PUNISH THE UNHOLY", Constants.BaseCooldown, 300, Constants.PriestSpellPower * 5));
                Hero holyPriest = new HolyPriest(playerName, Constants.PriestHealth, Constants.PriestHealthRegen
                    , actions, Constants.HeroBaseArmor, Constants.PriestMana, Constants.PriestManaRegen, Constants.PriestSpellPower);
                players.Add(holyPriest);
            }
            else if (typeOfPriest == "DISCIPLINE")
            {
                actions.Add(new Shield("POWER WORD: SHIELD", Constants.BaseCooldown, 200,  40));
                actions.Add(new Silence("SILENCE", Constants.BaseCooldown, 300));
                actions.Add(new PurgeTheWicked("PURGE THE WICKED", Constants.BaseCooldown, 300, Constants.PriestSpellPower * 5));
                Hero disciplinePriest = new DisciplinePriest(playerName, Constants.PriestHealth, Constants.PriestHealthRegen
                    , actions, Constants.HeroBaseArmor, Constants.PriestMana, Constants.PriestManaRegen, Constants.PriestSpellPower);
                players.Add(disciplinePriest);
            }
            else
            {
                actions.Add(new CurseOfDeath("CURSE OF DEATH", Constants.BaseCooldown, 150, 3, Constants.PriestSpellPower));
                actions.Add(new Sadism("SADISM", Constants.BaseCooldown, 300, 50, 30));
                actions.Add(new MindBlast("MIND BLAST", Constants.BaseCooldown, 300, Constants.PriestSpellPower * 4));
                Hero shadowPriest = new ShadowPriest(playerName, Constants.PriestHealth, Constants.PriestHealthRegen
                    , actions, Constants.HeroBaseArmor, Constants.PriestMana, Constants.PriestManaRegen, Constants.PriestSpellPower);
                players.Add(shadowPriest);
            }
        }
    }
}
