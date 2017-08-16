using NUnit.Framework;
using System.Collections.Generic;
using Battle4Beers.Client.Models;


namespace Battle4Beers.Tests
{
    [TestFixture]
    public class WarriorTests
    {
        private const int health = 20;
        private const int fullHealth = 1700;
        private const int healthRegeneration = 50;
        private const int armor = 5;
        private const int rage = 50;
        private const int attackPower = 10;

        private Warrior sut;

        [SetUp]
        public void TestInit()
        {
            sut = new BerserkerWarrior("Ragnar", health, healthRegeneration, new List<Action>(), armor, rage, attackPower);
        }

        [Test]
        public void IsWarriortHeroRegenerateHealth()
        {
            //Arrange

            //Act
            sut.Regenerate();
            //Assert
            Assert.AreEqual(80, sut.Health);
        }

        [Test]
        public void DoesNotWarriorHeroRegenerateWhenHealthAndManaAreFull()
        {
            //Arrange
            this.sut = new BerserkerWarrior("Ragnar", fullHealth, healthRegeneration, new List<Action>(), armor, rage, attackPower);

            //Act
            sut.Regenerate();
            //Assert
            Assert.AreEqual(2600, sut.Health);
        }

        [Test]
        public void IsWarriorGetRageOnHit()
        {
            //Arrange

            //Act
            sut.GetRageOnHit();
            //Assert
            Assert.AreEqual(70, sut.Rage);
        }

        [Test]
        public void DoesNotWarriorGetRageOnHitOverLimit()
        {
            //Arrange

            //Act
            sut.GetRageOnHit();
            sut.GetRageOnHit();
            sut.GetRageOnHit();

            //Assert
            Assert.AreEqual(100, sut.Rage);
        }
    }
}
