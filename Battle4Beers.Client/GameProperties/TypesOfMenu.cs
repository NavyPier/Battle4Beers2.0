using Battle4Beers.Client.GameProperties;
using Battle4Beers.Client.Models;
using Battle4Beers.Client.Utilities.Constants;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public static Models.Action ActionsMenu(Hero player)
        {
            var energyTypeAndAmount = HeroTypeChecker.GetHeroEnergyTypeAndAmount(player);
            var title = $"{player.Name} NEEDS TO SELECT AN ACTION: Health: {player.Health} ARMOR {player.Armor} {energyTypeAndAmount[0]}: {energyTypeAndAmount[1]}";
            var isAmplified = HeroTypeChecker.CheckForPassive(player);
            if (isAmplified)
            {
                title += $" {player.Name}'S DAMAGE IS BUFFED DUE TO PASSIVE";
            }
            var firstAction = player.Actions[0].ToString();
            var secondAction = player.Actions[1].ToString();
            var thirdAction = player.Actions[2].ToString();
            var fourthAction = player.Actions[3].ToString();
            var action = MenuDrawer.DrawMenu(new List<string>() { title, firstAction, secondAction, thirdAction, fourthAction });
            return player.Actions.Where(a => a.Name.Contains(action.Trim(':'))).First();
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


        public static List<List<Hero>> ChooseFirstAttacker(List<Hero> firstTeam, List<Hero> secondTeam)
        {
            //Keeps track of teams/players scores
            Dictionary<List<Hero>, int> heroesScores = new Dictionary<List<Hero>, int>();
            heroesScores.Add(firstTeam, 0);
            heroesScores.Add(secondTeam, 0);

            //Used for accurate messages
            string first = firstTeam.First().Name;
            string second = secondTeam.First().Name;
            if (firstTeam.Count > 1)
            {
                first = $"First Team({firstTeam[0].Name} and {firstTeam[1].Name})";
                second = $"Second Team({secondTeam[0].Name} and {secondTeam[1].Name})";
            }
            List<string> firstSecondTeamMessage = new List<string>() { first, second };

            Console.Clear();
            Instructions(Constants.instructionBeerStart, Constants.pressEnterText);

            while (true)
            {
                int counter = 0;
                while (counter <= 1)
                {
                    Instructions(firstSecondTeamMessage.First(), "PRESS ENTER TO CONTINUE AND CHOOSE KEG.");
                    var message = firstSecondTeamMessage.First();

                    var beerSelected = MenuDrawer
                            .DrawMenu(new List<string>() { "Choose", Constants.beer1, Constants.beer2, Constants.beer3, Constants.beer4 })
                            .Trim('-');

                    Random rnd = new Random();
                    var luckyNumber = rnd.Next(1, 4);
                    if (luckyNumber == int.Parse(beerSelected))
                    {
                        Console.Clear();
                        message = firstSecondTeamMessage.First() + " found the beer !";
                        Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (message.Length / 2)) + "}"
                        , message));
                        Pause(4);
                        var name = heroesScores.First().Key;
                        heroesScores[name]++;
                    }
                    else
                    {
                        Console.Clear();
                        message = firstSecondTeamMessage.First() + $" wrong answer! The beer was behind number{luckyNumber}.";
                        Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (message.Length / 2)) + "}"
                        , message));
                        Pause(2);
                    }

                    counter++;
                    firstSecondTeamMessage.Reverse();
                    heroesScores.Reverse();
                }
                if (heroesScores.First().Value != heroesScores.Last().Value)
                {
                    heroesScores.OrderByDescending(x => x.Value);
                    break;
                }
            }
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("First team to attack:".ToString().Length / 2)) + "}"
            , "FIRST TEAM TO ATTACK:"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (firstSecondTeamMessage.Last().Length / 2)) + "}"
            , firstSecondTeamMessage.Last()));
            Pause(3);

            List<List<Hero>> orderedTeams = new List<List<Hero>>();
            orderedTeams.Add(heroesScores.Last().Key);
            orderedTeams.Add(heroesScores.First().Key);
            return orderedTeams;
        }

        static void Pause(int sec)
        {
            Console.WriteLine();
            var pauseProc = Process.Start(
                new ProcessStartInfo()
                {
                    FileName = "cmd",
                    Arguments = "/C TIMEOUT /t " + sec + " /nobreak > NUL",
                    UseShellExecute = false
                });
            pauseProc.WaitForExit();
        }

        public static Hero SelectATarget(List<Hero> players)
        {
            var title = "SELECT YOUR TARGET";
            var firstTarget = $"{players[0].Name} HEALTH: {players[0].Health} ARMOR: {players[0].Armor}";
            var secondTarget = $"{players[1].Name} HEALTH: {players[1].Health} ARMOR: {players[1].Armor}";
            var target = MenuDrawer.DrawMenu(new List<string> { title, firstTarget, secondTarget });
            return players.Where(a => a.Name == target).First();
        }
    }
}
