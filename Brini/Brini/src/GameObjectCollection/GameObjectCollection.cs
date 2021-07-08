using System;
using System.Collections.Generic;
using System.Text;
using Brini.src.GameObject;

namespace Brini.src.GameObjectCollection
{
    class GameObjectCollection : IGameObjectCollection
    {
        List<IGameObject> gameObjectList;

        public GameObjectCollection()
        {
            this.gameObjectList = new List<IGameObject>();
        }

        public void Spawn(IGameObject obj)
        {
            this.gameObjectList.Add(obj);
        }

        public void Despawn(IGameObject obj)
        {
            this.gameObjectList.Remove(obj);
        }

        List<IGameObject> IGameObjectCollection.getGameObjectCollection()
        {
            return this.gameObjectList;
        }
    }
}
