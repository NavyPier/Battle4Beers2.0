using NUnit.Framework;
using System.Collections.Generic;
using Battle4Beers.Client.Models;
using Battle4Beers.Client.Models.Actions.PriestActions.DisciplinePriest;

namespace Battle4Beers.Tests
{
    [TestFixture]
    public class DisciplinePriestTests
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
        public void ActivatePassiveWithFireArmor()
        {
            //Arrange
            DisciplinePriest sut = new DisciplinePriest("Patric", health, healthRegeneration, new List<Action>() { new Shield("SHIELD", 3, 3, 4) }, armor, mana, manaRegen, spellPower);

            //Act
            sut.ActivatePassive("SHIELD", sut);

            //Assert
            Assert.IsTrue(sut.IsShielded);
            Assert.AreEqual(3, sut.PassiveDuration);
        }

        [Test]
        public void DisciplinePriestTakingDamageWhenIsShielded()
        {
            //Arrange
            DisciplinePriest sut = new DisciplinePriest("Patric", health, healthRegeneration, new List<Action>() { new Shield("SHIELD", 3, 3, 4) }, armor, mana, manaRegen, spellPower);

            //Act
            sut.ActivatePassive("SHIELD", sut);
            sut.TakeDamage(damage);

            //Assert
            Assert.AreEqual(175, sut.Health);
        }

        [Test]
        public void DisciplinePriestTakingDamageWhenArmorIsLessThanDamage()
        {
            //Arrange
            DisciplinePriest sut = new DisciplinePriest("Patric", health, healthRegeneration, new List<Action>() { new Shield("SHIELD", 3, 3, 4) }, armor, mana, manaRegen, spellPower);

            //Act
            sut.TakeDamage(damage);

            //Assert
            Assert.AreEqual(155, sut.Health);
        }

        [Test]
        public void WillDisciplinePriestTakingDamageWhenArmorIsMoreThanDamage()
        {
            //Arrange
            DisciplinePriest sut = new DisciplinePriest("Patric", health, healthRegeneration, new List<Action>() { new Shield("SHIELD", 3, 3, 4) }, armor, mana, manaRegen, spellPower);

            //Act
            sut.TakeDamage(smallDamage);

            //Assert
            Assert.AreEqual(200, sut.Health);
            Assert.AreEqual(1, sut.Armor);
        }
    }
}
