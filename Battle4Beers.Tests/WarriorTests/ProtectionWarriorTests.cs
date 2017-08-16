using NUnit.Framework;
using System.Collections.Generic;
using Battle4Beers.Client.Models;
using Battle4Beers.Client.Models.Actions.WarriorActions;


namespace Battle4Beers.Tests
{
    [TestFixture]
    public class ProtectionWarriorTests
    {
        private const int health = 20;
        private const int healthRegeneration = 50;
        private const int armor = 5;
        private const int rage = 20;
        private const int attackPower = 10;

        [Test]
        public void ActivatePassiveWithHibernate()
        {
            //Arrange
            ProtectionWarrior sut = new ProtectionWarrior("Protector", health, healthRegeneration, new List<Action>() { new Hibernate("HIBERNATE", 3, 3, 4) }, armor, rage, attackPower);

            //Act
            sut.ActivatePassive("HIBERNATE", sut);

            //Assert
            Assert.IsTrue(sut.Hibernating);
            Assert.AreEqual(1, sut.PassiveDuration);
        }
    }
}
