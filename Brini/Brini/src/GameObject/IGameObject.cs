using System;

namespace Brini.src.GameObject
{
    interface IGameObject
    {
        /// <summary>
        /// Repeatedly called during the game loop.
        /// </summary>
        /// <param name="elapsed"></param>
        void Update(int elapsed);

        /// <summary>
        /// The number of Object lifes.
        /// </summary>
        int Lifes { get; set; }

        /// <summary>
        /// True is the number of lifes of the Object is > 0
        /// </summary>
        Boolean IsAlive { get; set; }

        /// <summary>
        /// Decreases the number of lifes of the Object.
        /// </summary>
        void Hitted();

        /// <summary>
        /// GameObject's position 2D in the World.
        /// </summary>
        IP2d Position { get; set; }
    }
}