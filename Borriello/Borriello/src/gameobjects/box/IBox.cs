using System;
using System.Collections.Generic;
using System.Text;
using Borriello.src.gameobjects.powerup;

namespace Borriello.src.gameobjects.box
{
    interface IBox : IGameObject
    {
        /// <summary>
        /// True if the Box contains the PowerUp
        /// </summary>
        Boolean IsPresent { get; set; }

        /// <summary>
        /// Fill the Box with a PowerUp.
        /// </summary>
        /// <param name="pu"></param>
        void FillBox(IPowerUp pu);

        /// <summary>
        /// PowerUp contained into the Box
        /// </summary>
        IPowerUp PowerUp { get; set; }

    }
}
