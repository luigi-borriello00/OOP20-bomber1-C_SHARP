using Mazzanti.src.gameobjects.bomb;
using Mazzanti.src.gameobjects.common;
using Mazzanti.src.gameobjects.explosion;
using NUnit.Framework;

namespace Mazzanti
{
    public class Tests
    {
        IBomb Bomb;
        IExplosion Explosion;

        [SetUp]
        public void Setup()
        {
            this.Bomb = new Bomb(new P2d(0, 0), 3, true);
        }

        [Test]
        public void TestExplosion()
        {
            Assert.False(this.Bomb.IsExploded);
            this.Bomb.Explode();
            Assert.True(this.Bomb.IsExploded);
        }

        [Test]
        public void TestUpdate()
        {
            Assert.False(this.Bomb.IsExploded);
            for(int c = 0; c < IBomb.TIME_TO_EXPLODE; c++)
            {
                this.Bomb.Update(0);
            }
            Assert.False(this.Bomb.IsExploded);
            this.Bomb.Update(0);
            Assert.True(this.Bomb.IsExploded);
        }
    }
}