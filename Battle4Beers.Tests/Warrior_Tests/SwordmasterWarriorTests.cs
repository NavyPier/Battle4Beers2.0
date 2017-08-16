using NUnit.Framework;
using System.Collections.Generic;
using Battle4Beers.Client.Models;
using Battle4Beers.Client.Models.Actions.WarriorActions.Swordmaster;

namespace Battle4Beers.Tests.WarriorTests
{
    [TestFixture]
    public class SwordmasterWarriorTests
    {
        private const int health = 20;
        private const int healthRegeneration = 50;
        private const int armor = 5;
        private const int rage = 20;
        private const int attackPower = 10;

        [Test]
        public void ActivatePassiveWithLevelUpCriticalStrike()
        {
            //Arrange
            SwordmasterWarrior sut = new SwordmasterWarrior("Avanger", health, healthRegeneration, new List<Action>() { new LevelUpCrit("LEVEL UP CRITICAL STRIKE", 3, 3) }, armor, rage, attackPower);

            //Act
            sut.ActivatePassive("LEVEL UP CRITICAL STRIKE", sut);

            //Assert
            Assert.IsTrue(sut.CriticalStrike);
            Assert.AreEqual(3, sut.PassiveDuration);
        }
    }
}
