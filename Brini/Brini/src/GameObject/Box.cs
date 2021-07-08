using System;
using System.Collections.Generic;
using System.Text;

namespace Brini.src.GameObject
{
    class Box : GameObject, IBox
    {
        public bool IsPresent { get; set; }
        public IPowerUp PowerUp { get; set; }

        public override void Update(int elapsed)
        {

        }

        public override void Hitted()
        {
            this.IsPresent = false;
            this.Lifes = this.Lifes - 1;
            if (this.Lifes == 0)
            {
                this.IsAlive = false;
            }
        }
        void IBox.FillBox(IPowerUp pu)
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
