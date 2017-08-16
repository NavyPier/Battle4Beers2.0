using Battle4Beers.Client.Models;
using NUnit.Framework;
using System.Collections.Generic;
using Battle4Beers.Client.Models.Actions;

namespace Battle4Beers.Tests
{
    [TestFixture]
    public class ArcaneMageTests
    {
        private const int health = 20;
        private const int fullHealth = 2200;
        private const int healthRegeneration = 50;
        private const int armor = 5;
        private const int mana = 20;
        private const int fullMana = 2500;
        private const int spellPower = 10;
        private const int manaRegen = 100;

        [Test]
        public void ActivatePassiveWithAmplifyMagic()
        {
            //Arrange
            ArcaneMage sut = new ArcaneMage("Erystrazsa", health, healthRegeneration, new List<Action>(){new AmplifyMagic("AMPLIFY MAGIC", 5, 3) }, armor, mana, manaRegen, spellPower);
            
            //Act
            sut.ActivatePassive("AMPLIFY MAGIC", sut);

            //Assert
            Assert.IsTrue(sut.IsAmplified);
            Assert.AreEqual(3 , sut.PassiveDuration);
        }
    }
}
