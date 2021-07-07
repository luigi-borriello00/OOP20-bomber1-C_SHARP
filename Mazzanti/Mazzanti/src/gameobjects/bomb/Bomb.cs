using Mazzanti.src.gameobjects.common;
using Mazzanti.src.gameobjects.explosion;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mazzanti.src.gameobjects.bomb
{
    class Bomb : GameObject, IBomb
    {
        public const int TIME_TO_EXPLODE = 200;

        private int Thicks = 0;

        public bool IsExploded { get; set; }

        public Explosion Explosion { get; set; }

        public int FirePower { get; set; }

        public Boolean Pierced { get; set; }

        public Bomb(IP2d pos, int firePower, bool pierced) : base(pos)
        {
            FirePower = firePower;
            Pierced = pierced;
        }

        public void Explode()
        {
            this.Explosion = new Explosion(this.FirePower, this.Pierced, this.Position);
            this.IsExploded = true;
        }

        public override void Update(int elapsed)
        {
            if(this.Thicks++ == TIME_TO_EXPLODE)
            {
                this.Explode();
            }
        }
    }
}
