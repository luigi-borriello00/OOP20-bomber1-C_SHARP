using System;
using System.Collections.Generic;
using System.Text;
using Brini.src.GameObject;
using Brini.src.GameObjectCollection;
using NUnit.Framework;

namespace Brini.test
{
    class GameObjectCollectionTest
    {
        List<GameObject> list = new List<GameObject>();
        IBox box;
        IGameObjectCollection collection = new GameObjectCollection();

        [SetUp]
        public void Setup()
        {
            box = new Box(new P2d(1,1));
            list.Add((GameObject)box);
            collection.Spawn(box);
        }

        [Test]
        public void TestCollection()
        {
            Assert.AreEqual(this.list, this.collection.getGameObjectCollection());
            this.collection.Despawn(box);
            Assert.AreEqual(this.collection.getGameObjectCollection().Count, 0);
            this.collection.Spawn(box);
            Assert.AreNotEqual(this.collection.getGameObjectCollection().Count, 0);
        }
    }
}
