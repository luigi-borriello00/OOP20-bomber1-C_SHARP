using System;
using System.Collections.Generic;
using System.Text;

namespace Mazzanti.src.gameobjects.common
{
    interface IGameObject
    {
        void Update(int elapsed);

        int Lifes { get; set; }

        Boolean IsAlive { get; set; }

        void Hitted();

        IP2d Position { get; set; }
    }
}