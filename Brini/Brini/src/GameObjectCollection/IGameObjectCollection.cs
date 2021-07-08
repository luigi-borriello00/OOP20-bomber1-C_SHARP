using System;
using System.Collections.Generic;
using System.Text;
using Brini.src.GameObject;

namespace Brini.src.GameObjectCollection
{
    interface IGameObjectCollection
    {

        /// <summary>
        /// Return a list of all GameObject
        /// </summary>
        /// <returns></returns>
        public List<IGameObject> getGameObjectCollection();

        /// <summary>
        /// Add object at the list of GameObject
        /// </summary>
        public void Spawn(IGameObject obj);

        /// <summary>
        /// Delete object at the list of GameObject
        /// </summary>
        public void Despawn(IGameObject obj);


    }
}