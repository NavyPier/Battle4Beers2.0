using System.Collections.Generic;
using Battle4Beers.Client;
using Battle4Beers.Client.Models;
using Moq;
using NUnit.Framework;

namespace Battle4Beers.Tests
{
    [TestFixture]
    public class CombatTests
    {
        private List<Hero> firstTeam;
        private List<Hero> secondTeam;
        private Hero player1;
        private Hero player2;


        [SetUp]
        public void TestInit()
        {
            player1 = new ArcaneMage("Gandalf", 12, 12, new List<Action>(), 10, 10, 10, 10);
            player2 = new SwordmasterWarrior("Aragorn",10,2,new List<Action>(), 5, 6, 1);
            firstTeam = new List<Hero>(){ player1 };
            secondTeam = new List<Hero>(){player2};

        }

        [TearDown]
        public void CleanUp()
        {
            Combat.firstTeam = new List<Hero>();
            Combat.secondTeam = new List<Hero>();
        }

        //[Test]
        public void ArrangeTeamsSetsFirstAndSecondTeamProperly()
        {
            // Arrange


            // Act
            //Too much coupling -> imposible for testing
            Combat.ArrangeTeams(new List<Hero>(){player1, player2});

            // Assert
            Assert.AreEqual(new List<Hero>(){player1}, Combat.firstTeam);
            Assert.AreEqual(new List<Hero>() { player2 }, Combat.secondTeam);

        }
        
    }
}
