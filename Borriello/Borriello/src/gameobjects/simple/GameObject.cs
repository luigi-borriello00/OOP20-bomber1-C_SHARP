using System;
using System.Collections.Generic;
using System.Text;

namespace Borriello.src.gameobjects
{
    abstract class GameObject : IGameObject
    {
        public int Lifes { get ; set ; }

        public bool IsAlive { get; set; }

        public IP2d Position { get; set; }

        public virtual void Hitted()
        {
            this.Lifes = this.Lifes - 1;
            if(this.Lifes == 0)
            {
                this.IsAlive = false;
            }
        }

        public GameObject(IP2d pos)
        {
            this.Lifes = 1;
            this.IsAlive = true;
            this.Position = pos;
        }

        public abstract void Update(int elapsed);
    }
}
