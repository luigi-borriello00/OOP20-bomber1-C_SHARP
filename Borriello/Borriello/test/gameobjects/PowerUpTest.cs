using System;
using System.Collections.Generic;
using System.Text;
using Borriello.src.gameobjects;
using Borriello.src.gameobjects.powerup;
using NUnit.Framework;

namespace Borriello.test.gameobjects
{
    class PowerUpTest
    {
        private IPowerUp powerUp;
        private IPowerUp powerUp2;

        [SetUp]
        public void Setup()
        {
            this.powerUp = new PowerUp(PowerUpType.AMMO, new P2d(1, 1));
            this.powerUp2 = new PowerUp(PowerUpType.PIERCE, new P2d(1, 1));
        }

        [Test]
        public void TestType()
        {
            Assert.AreEqual(this.powerUp.Type, PowerUpType.AMMO);
            Assert.AreEqual(this.powerUp2.Type, PowerUpType.PIERCE);
            Assert.AreNotEqual(this.powerUp.Type, PowerUpType.FIREPOWER);
            Assert.AreNotEqual(this.powerUp2.Type, PowerUpType.TIMER);
            Assert.AreNotEqual(this.powerUp.Type, this.powerUp2.Type);
        }
    }
}
