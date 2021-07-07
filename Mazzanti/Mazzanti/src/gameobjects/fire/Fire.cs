using Mazzanti.src.gameobjects.common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mazzanti.src.gameobjects.fire
{
    internal class Fire : GameObject, IFire
    {
        public const int LIFE_TIME = 100;

        private int Thicks;

        public Fire(IP2d pos) : base(pos)
        {
            this.Thicks = 0;
        }

        public override void Update(int elapsed)
        {
            if(this.Thicks++ == LIFE_TIME)
            {
                this.IsAlive = false;
            }
        }
    }
}
