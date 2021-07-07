using System;
using System.Collections.Generic;
using System.Text;

namespace Mazzanti.src.gameobjects.common
{
    interface IP2d
    {
        int X { get; set; }

        int Y { get; set; }

        Boolean IsEqualTo(IP2d point);
    }
}
