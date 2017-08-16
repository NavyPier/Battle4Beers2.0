using Battle4Beers.Client.Models;
using NUnit.Framework;
using System.Collections.Generic;
using Battle4Beers.Client.Models.Actions;

namespace Battle4Beers.Tests
{
    [TestFixture]
    public class FrostMageTests
    {
        private const int health = 20;
        private const int healthRegeneration = 50;
        private const int armor = 5;
        private const int mana = 20;
        private const int spellPower = 10;
        private const int manaRegen = 100;

        [Test]
        public void ActivatePassiveWithIcyVeins()
        {
            //Arrange
            FrostMage sut = new FrostMage("Erystrazsa", health, healthRegeneration, new List<Action>() { new IcyVeins("ICY VEINS", 3, 3, 3) }, armor, mana, manaRegen, spellPower);

            //Act
            sut.ActivatePassive("ICY VEINS", sut);

            //Assert
            Assert.IsTrue(sut.IcyVeins);
            Assert.AreEqual(0, sut.PassiveDuration);
            Assert.AreEqual(-1, sut.FrostArmorDuration);
            Assert.AreEqual(2, sut.IcyVeinsDuration);
        }
    }
}
