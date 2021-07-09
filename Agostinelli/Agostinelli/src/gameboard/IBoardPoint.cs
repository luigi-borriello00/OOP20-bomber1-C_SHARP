using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agostinelli.src.gameboard
{
    interface IBoardPoint
    {

        int X { get; set; }

        int Y { get; set; }

        Markers Marker { get; set; }

        void SetPoint(int newX, int newY, Markers newMarker);
    }
}
