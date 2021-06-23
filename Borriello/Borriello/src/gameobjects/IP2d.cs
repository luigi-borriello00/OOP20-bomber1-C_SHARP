using System;
using System.Collections.Generic;
using System.Text;

namespace Borriello.src.gameobjects
{
    interface IP2d
    {
        /// <summary>
        /// GameObject's position 2D in the World.
        /// </summary>
        Tuple<int, int> Position { get; set; }
    }
}
