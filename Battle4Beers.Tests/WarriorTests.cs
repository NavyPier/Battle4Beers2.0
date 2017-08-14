﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Battle4Beers.Client.Models;
using Action = Battle4Beers.Client.Models.Action;

namespace Battle4Beers.Tests
{
    [TestFixture]
    public class WarriorTests
    {
        private const int health = 20;
        private const int fullHealth = 2600;
        private const int healthRegeneration = 50;
        private const int armor = 5;
        private const int rage = 50;
        private const int attackPower = 10;

        private Warrior sut;

        [SetUp]
        public void TestInit()
        {
            sut = new BerserkerWarrior("Ragnar", health, healthRegeneration, new List<Action>(), armor, rage, attackPower);
        }

        [Test]
        public void IsWarriortHeroRegenerateHealth()
        {
            //Arrange

            //Act
            sut.Regenerate();
            //Assert
            Assert.AreEqual(80, sut.Health);
        }

        [Test]
        public void IsWarriorHeroDoesNotRegenerateWhenHealthAndManaAreFull()
        {
            //Arrange
            this.sut = new BerserkerWarrior("Ragnar", fullHealth, healthRegeneration, new List<Action>(), armor, rage, attackPower);

            //Act
            sut.Regenerate();
            //Assert
            Assert.AreEqual(2600, sut.Health);
        }

        [Test]
        public void IsWarriorGetRageOnHit()
        {
            //Arrange

            //Act
            sut.GetRageOnHit();
            //Assert
            Assert.AreEqual(70, sut.Rage);
        }

        [Test]
        public void DoesNotWarriorGetRageOnHitOverLimit()
        {
            //Arrange

            //Act
            sut.GetRageOnHit();
            sut.GetRageOnHit();
            sut.GetRageOnHit();

            //Assert
            Assert.AreEqual(100, sut.Rage);
        }
    }
}
