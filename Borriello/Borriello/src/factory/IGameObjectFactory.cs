using System;
using System.Collections.Generic;
using System.Text;
using Borriello.src.gameobjects;
using Borriello.src.gameobjects.powerup;

namespace Borriello.src.factory
{
    interface IGameObjectFactory
    {
        /// <summary>
        /// Create a new Box.
        /// </summary>
        /// <returns></returns>
        IGameObject CreateBox(IP2d pos);

        /// <summary>
        /// Create a new PowerUp.
        /// </summary>
        /// <returns></returns>
        IGameObject CreatePowerUp(PowerUpType type, IP2d pos);
    }
}
