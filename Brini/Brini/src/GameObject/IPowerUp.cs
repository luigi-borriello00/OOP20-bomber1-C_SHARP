using System;

namespace Brini.src.GameObject
{
    interface IPowerUp : IGameObject
    {
        /// <summary>
        /// The type of the PowerUp
        /// </summary>
        PowerUpType Type { get; }

        /// <summary>
        /// True, if the PowerUp is dropped by the box
        /// </summary>
        Boolean Released { get; set; }

        /// <summary>
        /// When the Box is destroyed, it calls this method.
        /// </summary>
        void Release();

    }
}