using Mazzanti.src.gameobjects.common;
using Mazzanti.src.gameobjects.explosion;
using NUnit.Framework;

namespace Mazzanti
{
    public class ExplosionTest
    {

        IExplosion Explosion1;
        IExplosion Explosion2;
        IExplosion Explosion3;
        IP2d Center1;
        IP2d Center2;
        IP2d Center3;

        
        [SetUp]
        public void Setup()
        {
            this.Center1 = new P2d(0, 1);
            this.Center2 = new P2d(1, 0);
            this.Center3 = new P2d(1, 1);
            this.Explosion1 = new Explosion(10, false, this.Center1);
            this.Explosion2 = new Explosion(100, true, this.Center2);
            this.Explosion3 = new Explosion(1000, false, this.Center3);
        }

        [Test]
        public void TestFirePower()
        {
            Assert.True(this.Explosion1.FirePower == 10);
            Assert.True(this.Explosion2.FirePower == 100);
            Assert.True(this.Explosion3.FirePower == 1000);
        }

        [Test]
        public void TestPierced()
        {
            Assert.False(this.Explosion1.IsPierced);
            Assert.True(this.Explosion2.IsPierced);
            Assert.False(this.Explosion3.IsPierced);
        }

        [Test]
        public void TestCenter()
        {
            Assert.Equals(this.Explosion1.Center, this.Center1);
            Assert.Equals(this.Explosion2.Center, this.Center2);
            Assert.Equals(this.Explosion3.Center, this.Center3);
        }
    }
}