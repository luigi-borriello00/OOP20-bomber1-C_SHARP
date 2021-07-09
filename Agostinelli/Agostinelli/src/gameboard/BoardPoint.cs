using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agostinelli.src.gameboard
{
    public class BoardPoint : IBoardPoint
    {
        private int x;
        private int y;
        private Markers pointMarker;

        public BoardPoint()
        {

        }

        public BoardPoint(Markers newMarker)
        {
            this.pointMarker = newMarker;
        }

        public BoardPoint(int xToSet, int yToSet)
        {
            this.x = xToSet;
            this.y = yToSet;
        }

        public BoardPoint(int xToSet, int yToSet, Markers newMarker)
        {
            this.x = xToSet;
            this.y = yToSet;
            this.pointMarker = newMarker;
        }

        public int X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public int Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public Markers Marker
        {
            get { return this.pointMarker; }
            set { this.pointMarker = value; }
        }

        public bool Equals(BoardPoint pointToCheck)
        {
            return this.x == pointToCheck.X && this.y == pointToCheck.Y;
        }

        public void SetPoint(int newX, int newY, Markers newMarker)
        {
            this.x = newX;
            this.y = newY;
            this.pointMarker = newMarker;
        }

        public override String ToString()
        {
            return this.X + ", " + this.Y;
        }
    }
}
