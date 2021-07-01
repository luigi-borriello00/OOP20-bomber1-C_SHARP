using System;
using System.Collections.Generic;
using System.Text;

namespace Borriello.src.gameobjects
{
    class P2d : IP2d
    {
        public int X { get ; set ; }
        public int Y { get; set; }

        public P2d(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public bool IsEqualTo(IP2d point)
        {
            if (point.X == this.X && point.Y == this.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
