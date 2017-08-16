using NUnit.Framework;
using System.Collections.Generic;
using Battle4Beers.Client.Models;
using Battle4Beers.Client.Models.Actions.PriestActions.ShadowPriest;

namespace Battle4Beers.Tests
{
    [TestFixture]
    public class ShadowPriestTests
    {
        private const int health = 200;
        private const int healthRegeneration = 50;
        private const int armor = 5;
        private const int mana = 20;
        private const int spellPower = 10;
        private const int manaRegen = 100;
        private const int damage = 50;
        private const int smallDamage = 4;

        [Test]
        public void ActivatePassiveWithSadism()
        {
            //Arrange
            ShadowPriest sut = new ShadowPriest("Patric", health, healthRegeneration,
                new List<Action>() {new Sadism("SADISM", 3, 3, 4, 5)}, armor, mana, manaRegen, spellPower);

            //Act
            sut.ActivatePassive("SADISM", sut);

            //Assert
            Assert.IsTrue(sut.Sadist);
            Assert.AreEqual(3, sut.PassiveDuration);
        }
    }
}
