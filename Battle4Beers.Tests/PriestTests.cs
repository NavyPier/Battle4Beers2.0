using NUnit.Framework;
using System.Collections.Generic;
using Battle4Beers.Client.Models;
using Action = Battle4Beers.Client.Models.Action;

namespace Battle4Beers.Tests
{
    [TestFixture]
    public class PriestTests
    {
        private const int health = 20;
        private const int fullHealth = 1400;
        private const int healthRegeneration = 50;
        private const int armor = 5;
        private const int mana = 20;
        private const int fullMana = 2700;
        private const int spellPower = 10;
        private const int manaRegen = 100;

        private Priest sut;

        [SetUp]
        public void TestInit()
        {
            sut = new HolyPriest("Patriarch", health, healthRegeneration, new List<Action>(), armor, mana, manaRegen, spellPower);
        }

        [Test]
        public void IsPriestHeroRegenerate()
        {
            //Arrange

            //Act
            sut.Regenerate();
            //Assert
            Assert.AreEqual(70, sut.Health);
            Assert.AreEqual(130, sut.Mana);
        }

        [Test]
        public void DoesNotPriestHeroRegenerateWhenHealthAndManaAreFull()
        {
            //Arrange
            sut = new HolyPriest("Patriarch", fullHealth, healthRegeneration, new List<Action>(), armor, fullMana, manaRegen, spellPower);

            //Act
            sut.Regenerate();
            //Assert
            Assert.AreEqual(1400, sut.Health);
            Assert.AreEqual(2700, sut.Mana);
        }
    }
}
