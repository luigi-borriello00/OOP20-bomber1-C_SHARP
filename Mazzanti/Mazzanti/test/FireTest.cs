using Mazzanti.src.gameobjects.common;
using Mazzanti.src.gameobjects.fire;
using NUnit.Framework;

namespace Mazzanti
{
    public class FireTest
    {
        IFire Fire;

        [SetUp]
        public void Setup()
        {
            Fire = new Fire(new P2d(0, 0));
        }

        [Test]
        public void TestUpdate()
        {
            Assert.True(this.Fire.IsAlive);
            for (int c = 0; c < IFire.LIFE_TIME; c++)
            {
                this.Fire.Update(0);
            }
            Assert.True(this.Fire.IsAlive);
            this.Fire.Update(0);
            Assert.False(this.Fire.IsAlive);
        }
    }
}