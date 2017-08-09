using System;
using Battle4Beers.Client.Models;
using Battle4Beers.Client.Utilities.Constants;
using System.Collections.Generic;
using System.Linq;

namespace Battle4Beers.Client
{
    public class TypesOfMenu
    {
        //Gives the MenuDraw method the properties needed to draw the Start Menu.
        public static void StartMenu()
        {
            var title = "WELCOME TO BATTLE FOR BEERS!";
            var newGame = "NEW GAME";
            var beersEarned = "BEERS EARNED";
            var instructions = "INSTRUCTIONS";
            var quit = "QUIT";
            var command = MenuDrawer.DrawMenu(new List<string>() { title, newGame, beersEarned, instructions, quit });
            var manager = new ActionManager();
            manager.DoAction(command);
        }
        //Writes instructions and loops untill enter received.
        internal static void Instructions(params string[] textToWrite)
        {
            foreach (var text in textToWrite)
            {
            int instructionsTextLenght = text.Length;
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (instructionsTextLenght / 2)) + "}"
                , text));
            }
            var keyInput = Console.ReadKey();
            while (keyInput.Key != ConsoleKey.Enter)
            {
                keyInput = Console.ReadKey();
            }
            Console.Clear();
        }
        //Gives the MenuDraw method the properties needed to draw an Action Menu for the current hero.
        public static void ActionsMenu(Hero player)
        {
            var title = "SELECT AN ACTION:";
            var firstAction = player.Actions[0].ToString();
            var secondAction = player.Actions[1].ToString();
            var thirdAction = player.Actions[2].ToString();
            var fourthAction = player.Actions[3].ToString();
            var command = MenuDrawer.DrawMenu(new List<string>() { title, firstAction, secondAction, thirdAction, fourthAction });
            var manager = new ActionManager();
            manager.DoAction(command);
        }

        public static void NewGameMenu()
        {
            var title = "WHAT TYPE OF GAME WOULD YOU LIKE TO PLAY?";
            var duelOption = "DUEL BETWEEN 2 PLAYERS";
            var arenaOption = "ARENA BATTLE BETWEEN 2 TEAMS, EACH OF 2 PLAYERS";
            var command = MenuDrawer.DrawMenu(new List<string>() { title, duelOption, arenaOption });
            var manager = new ActionManager();
            manager.DoAction(command);
        }

        public static void HeroSelectMenu(List<string> playerNames)
        {
            var playerNamesAndHeroes = new Dictionary<string, string>();
            for (int i = 0; i < playerNames.Count; i++)
            {
                var title = $"WHAT TYPE OF HERO WILL YOU CHOOSE FOR {playerNames[i]}?";
                var warrior = "WARRIOR";
                var mage = "MAGE";
                var priest = "PRIEST";
                var heroType = MenuDrawer.DrawMenu(new List<string>() { title, warrior, mage, priest });
                playerNamesAndHeroes[playerNames[i]] = heroType;
            }
            CharacterCreation.SelectHeroClass(playerNamesAndHeroes);
        }

        public static string HeroClassSelectMenu(string playerName, string heroType)
        {
            var title = $"SELECT WHAT TYPE OF {heroType} WILL {playerName} PLAY";
            var listOfHeroClasses = new List<string>();
            if (heroType == MenuActions.WARRIOR.ToString())
            {
                listOfHeroClasses = WarriorClassesMenu();
            }
            else if (heroType == MenuActions.MAGE.ToString())
            {
                listOfHeroClasses = MageClassesMenu();
            }
            else if (heroType == MenuActions.PRIEST.ToString())
            {
                listOfHeroClasses = PriestClassesMenu();
            }
            listOfHeroClasses.Insert(0, title);
            var classType = MenuDrawer.DrawMenu(listOfHeroClasses);
            return classType;
        }

        public static List<string> PriestClassesMenu()
        {
            var holyPriest = "HOLY";
            var disciplinePriest = "DISCIPLINE";
            var shadowPriest = "SHADOW";
            return new List<string>() { holyPriest, disciplinePriest, shadowPriest };
        }

        public static List<string> MageClassesMenu()
        {
            var arcaneMage = "ARCANE";
            var fireMage = "FIRE";
            var frostMage = "FROST";
            return new List<string>() { arcaneMage, fireMage, frostMage };
        }

        public static List<string> WarriorClassesMenu()
        {
            var swordMaster = "SWORDMASTER";
            var berserker = "BERSERKER";
            var protector = "PROTECTOR";
            return new List<string>() { swordMaster, berserker, protector };
        }

        public static int ChooseFirstAttacker()
        {
            Instructions(Constants.instructionBeerStart,Constants.pressEnterText);
            var title = "SELECT A BEER";
            var winner = MenuDrawer.DrawMenu(new List<string>() { title, Constants.beer1, Constants.beer2, Constants.beer3, Constants.beer4 }).Trim('-');
            var beerSelected = int.Parse(winner);
            return 0;
        }
    }
}
