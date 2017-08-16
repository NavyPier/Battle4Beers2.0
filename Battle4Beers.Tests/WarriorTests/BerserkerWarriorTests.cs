using NUnit.Framework;
using System.Collections.Generic;
using Battle4Beers.Client.Models;
using Battle4Beers.Client.Models.Actions;
using Battle4Beers.Client.Models.Actions.WarriorActions.Berseker;

namespace Battle4Beers.Tests
{
    [TestFixture]
    public class BerserkerWarriorTests
    {
        private const int health = 20;
        private const int healthRegeneration = 50;
        private const int armor = 5;
        private const int rage = 20;
        private const int attackPower = 10;
 
        [Test]
        public void ActivatePassiveWithFireArmor()
        {
            //Arrange
            BerserkerWarrior sut = new BerserkerWarrior("Avanger", health, healthRegeneration, new List<Action>() { new GoBerserk("GO BERSERK", 3, 3, 4) }, armor, rage, attackPower);

            //Act
            sut.ActivatePassive("GO BERSERK", sut);

            //Assert
            Assert.IsTrue(sut.IsBerserk);
            Assert.AreEqual(3, sut.PassiveDuration);
        }
    }
}
