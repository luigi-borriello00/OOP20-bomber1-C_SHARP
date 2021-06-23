using System;
using System.Collections.Generic;
using System.Text;
using Borriello.src.gameobjects;
using Borriello.src.gameobjects.box;
using Borriello.src.gameobjects.powerup;

namespace Borriello.src.factory
{
    class GameObjectFactory : IGameObjectFactory
    {
        public IGameObject CreateBox(IP2d pos)
        {
            return new Box(pos);
        }

        public IGameObject CreatePowerUp(PowerUpType type, IP2d pos)
        {
            return new PowerUp(type, pos);
        }
    }
}
