using System;

namespace Brini.src.GameObject
{
    interface IP2d
    {
        /// <summary>
        /// GameObject's X coord in the World.
        /// </summary>
        int X { get; set; }

        /// <summary>
        /// GameObject's Y coord in the World.
        /// </summary>
        int Y { get; set; }

        /// <summary>
        /// Return True if two point have the same Coords.
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        Boolean IsEqualTo(IP2d point);
    }
}