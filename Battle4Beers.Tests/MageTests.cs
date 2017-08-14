using Battle4Beers.Client.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Action = Battle4Beers.Client.Models.Action;

namespace Battle4Beers.Tests
{
    [TestFixture]
    public class MageTests
    {
        private const int health = 20;
        private const int fullHealth = 2200;
        private const int healthRegeneration = 50;
        private const int armor = 5;
        private const int mana = 20;
        private const int fullMana = 2500;
        private const int spellPower = 10;
        private const int manaRegen = 100;

        private Mage sut;

        [SetUp]
        public void TestInit()
        {
            sut = new ArcaneMage("Erystrazsa", health, healthRegeneration, new List<Action>(), armor, mana, manaRegen, spellPower);
        }

        [Test]
        public void IsMageHeroRegenerate()
        {
            //Arrange

            //Act
            sut.Regenerate();
            //Assert
            Assert.AreEqual(70, sut.Health);
            Assert.AreEqual(120, sut.Mana);
        }

        [Test]
        public void IsMageHeroDoesNotRegenerateWhenHealthAndManaAreFull()
        {
            //Arrange
            this.sut = new ArcaneMage("Erystrazsa", fullHealth, healthRegeneration, new List<Action>(), armor, fullMana, manaRegen, spellPower );

            //Act
            sut.Regenerate();
            //Assert
            Assert.AreEqual(2200, sut.Health);
            Assert.AreEqual(2500, sut.Mana);
        }
    }
}
