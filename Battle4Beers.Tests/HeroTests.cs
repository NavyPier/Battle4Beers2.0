using NUnit.Framework;
using System.Collections.Generic;
using Battle4Beers.Client.Models;
using Action = Battle4Beers.Client.Models.Action;

namespace Battle4Beers.Tests
{
    [TestFixture]
    public class HeroTests
    {
        private const int health = 20;
        private const int healthRegeneratuin = 2;
        private const int armor = 5;
        private const int rage = 6;
        private const int attackPower = 3;
        private const int heal = 15;
        private const int newArmor = 15;
        private const int littleDamage = 3;
        private const int hugeDamage = 9;


        private Hero sut;

        [SetUp]
        public void TestInit()
        {
            sut = new SwordmasterWarrior("Aragorn", health, healthRegeneratuin, new List<Action>(), armor, rage, attackPower);
        }
        [Test]
        public void IsPlayerHealed()
        {
            //Act
            sut.GetHealed(heal);

            //Assert
            Assert.AreEqual(35, sut.Health);
        }

        [Test]
        public void IsHeroArmoredUp()
        {
            //Arrange

            //Act
            sut.GainArmor(newArmor);
            //Assert
            Assert.AreEqual(20, sut.Armor);
        }
        [Test]
        public void HeroLoseArmorFirstThenHealth()
        {
            //Arrange

            //Act
            sut.TakeDamage(littleDamage);
            //Assert
            Assert.AreEqual(2, sut.Armor);
        }
        [Test]
        public void HeroLoseArmorAndHealth()
        {
            //Arrange

            //Act
            sut.TakeDamage(hugeDamage);
            //Assert
            Assert.AreEqual(0, sut.Armor);
            Assert.AreEqual(16, sut.Health);
        }
        [Test]
        public void RightHealthValue()
        {
            //Arrange

            //Act

            //Assert
            Assert.AreEqual(20, sut.Health);
        }
    }
}
