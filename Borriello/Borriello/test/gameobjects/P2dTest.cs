using System;
using System.Collections.Generic;
using System.Text;
using Borriello.src.gameobjects;
using NUnit.Framework;

namespace Borriello.test.gameobjects
{
    class P2dTest
    {
        private IP2d pos1;
        private IP2d pos2;

        [SetUp]
        public void Setup()
        {
            this.pos1 = new P2d(1, 1);
            this.pos2 = new P2d(1, 2);
        }

        [Test]
        public void TestX()
        {
            Assert.AreEqual(this.pos1.X, this.pos2.X);
        }

        [Test]
        public void TestY()
        {
            Assert.AreNotEqual(this.pos1.Y, this.pos2.Y);
        }

        [Test]
        public void TestXY()
        {
            Assert.IsFalse(this.pos1.IsEqualTo(this.pos2));
        }
    }
}
