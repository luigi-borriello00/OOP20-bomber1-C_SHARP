using System;
using System.Collections.Generic;
using System.Text;
using Borriello.src.gameobjects.powerup;

namespace Borriello.src.gameobjects.box
{
    class Box : GameObject, IBox
    {
        public bool IsPresent { get; set; }
        public IPowerUp PowerUp { get; set; }
        
        public override void Update(int elapsed)
        {
            
        }

        void FillBox(IPowerUp pu)
        {
            this.PowerUp = pu;
            this.IsPresent = true;
        }

        public Box(IP2d pos) : base(pos)
        {
            this.IsPresent = false;
            this.PowerUp = null;
        }

    }
}
