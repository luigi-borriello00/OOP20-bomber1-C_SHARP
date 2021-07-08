using System;
using System.Collections.Generic;
using System.Text;

namespace Brini.src.GameObject
{
    class PowerUp : GameObject, IPowerUp
    {
        public PowerUpType Type { get; }

        public bool Released { get; set; }

        public void Release()
        {
            this.Released = true;
        }

        public override void Update(int elapsed)
        {

        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="type"></param>
        public PowerUp(PowerUpType type, IP2d pos) : base(pos)
        {
            this.Type = type;
            this.Released = false;
        }
    }
}
