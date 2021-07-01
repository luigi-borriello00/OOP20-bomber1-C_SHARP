using System;
using System.Collections.Generic;
using System.Text;
using Borriello.src.gameobjects;
using Borriello.src.gameobjects.box;
using Borriello.src.gameobjects.powerup;
using NUnit.Framework;

namespace Borriello.test
{
    class BoxesTest
    {
        private IBox box;
        private IPowerUp pU;

        [SetUp]
        public void SetUp()
        {
            this.box = new Box(new P2d(5, 5));
            this.pU = new PowerUp(PowerUpType.AMMO, new P2d(5, 5));
        }

        [Test]
        public void GetPuTest()
        {
            this.box.FillBox(pU);
            Assert.IsTrue(this.box.IsPresent);
            this.box.Hitted();
            Assert.IsFalse(this.box.IsPresent);
        }

        [Test]
        public void GetLifeTest()
        {
            Assert.IsTrue(this.box.Lifes == 1);
            Assert.IsTrue(this.box.IsAlive);
            this.box.Hitted();
            Assert.IsTrue(this.box.Lifes == 0);
            Assert.IsFalse(this.box.IsAlive);
        }

    }
}
