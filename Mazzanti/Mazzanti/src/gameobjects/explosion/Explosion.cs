using Mazzanti.src.gameobjects.common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mazzanti.src.gameobjects.explosion
{
    class Explosion : IExplosion
    {
        public int FirePower { get; }
        public bool IsPierced { get; }
        public IP2d Center { get; }
        public Explosion(int firePower, bool isPierced, IP2d center)
        {
            FirePower = firePower;
            IsPierced = isPierced;
            Center = center;
        }
    }
}
