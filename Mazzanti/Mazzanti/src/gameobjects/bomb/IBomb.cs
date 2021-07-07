using Mazzanti.src.gameobjects.common;
using Mazzanti.src.gameobjects.explosion;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mazzanti.src.gameobjects.bomb
{
    interface IBomb : IGameObject
    {
        const int TIME_TO_EXPLODE = 200;

        Boolean IsExploded { get; set; }

        Explosion Explosion { get; set; }

        void Explode();

    }
}
