using System;
using System.Collections.Generic;
using System.Text;
using Mazzanti.src.gameobjects.common;

namespace Mazzanti.src.gameobjects.explosion
{
    interface IExplosion
    {
        /// <summary>
        /// Return the range of the Explosion
        /// </summary>
        int FirePower { get; }

        /// <summary>
        /// True if this Explosion can go across the wall
        /// </summary>
        Boolean IsPierced { get; }

        /// <summary>
        /// Return the IP2d referring to the center of this Explosion
        /// </summary>
        IP2d Center { get; }


    }
}
