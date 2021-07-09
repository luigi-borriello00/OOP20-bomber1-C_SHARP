using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agostinelli.src.gameboard
{
    public class GameBoard
    {
        private int rows;
        private int columns;
        private List<List<BoardPoint>> currentGameBoard;

        public GameBoard(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            this.currentGameBoard = new List<List<BoardPoint>>();

            for(int i = 0; i < this.rows; i++)
            {
                this.currentGameBoard.Add(new List<BoardPoint>());
                for(int j = 0; j < this.columns; j++)
                {
                    this.currentGameBoard.ElementAt(i).Add(new BoardPoint(i, j, Markers.ACCESSIBLE));
                }
            }
        }

        public GameBoard(List<List<String>> mapLayout)
        {
            this.rows = mapLayout.Count;
            this.columns = mapLayout.ElementAt(0).Count;
            this.currentGameBoard = new List<List<BoardPoint>>();

            for(int i = 0; i < this.rows; i++)
            {
                this.currentGameBoard.Add(new List<BoardPoint>());
                for (int j = 0; j < this.columns; j++)
                {
                    BoardPoint newPoint = new BoardPoint(i, j, Markers.ACCESSIBLE);
                    String item = mapLayout.ElementAt(i).ElementAt(j);
                    foreach(Markers marker in Enum.GetValues(typeof(Markers)))
                    {
                        if (String.Equals(marker, item))
                        {
                            newPoint.Marker = (Markers) marker;
                            break;
                        }
                    }

                    this.currentGameBoard.ElementAt(i).Add(newPoint);
                }
            }
        }

        public List<List<BoardPoint>> GameBoardProperty
        {
            get
            {
                return this.currentGameBoard;
            }

            set
            {
                this.currentGameBoard = value;
            }
        }

        public int Rows
        {
            get { return this.rows; }
        }

        public int Columns
        {
            get { return this.columns; }
        }

        public Boolean IsLegal(int x, int y)
        {
            return (x >= 0 && x < this.rows) && (y >= 0 && y < this.columns);
        }

        public Object GetItem(int x, int y)
        {
            return this.IsLegal(x, y) ? this.currentGameBoard.ElementAt(x).ElementAt(y) : null;
        }

        public Boolean SetItem(BoardPoint newPoint)
        {
            Boolean result = this.IsLegal(newPoint.X, newPoint.Y);
            if (result)
            {
                this.currentGameBoard.ElementAt(newPoint.X)[newPoint.Y] = newPoint;
            }

            return result;
        }

        public void SetItems(List<BoardPoint> positions)
        {
            foreach(BoardPoint point in positions)
            {
                this.SetItem(point);
            }
        }

        public Boolean IsAccessible(int x, int y)
        {
            Boolean result = this.IsLegal(x, y);
            Markers marker = this.currentGameBoard.ElementAt(x).ElementAt(y).Marker;
            Boolean secondResult = marker == Markers.ACCESSIBLE || marker == Markers.SPOT;

            return result && secondResult;
        }

        private Boolean CheckAccessibility(BoardPoint currentPoint, BoardPoint destination, Accessibility mode)
        {
            int k;
            int m;
            int xToCheck = 0;
            int yToCheck = 0;
            Boolean result = false;
            int currentCoordinates;
            int destinationCoordinates;

            if(mode == Accessibility.ROWS)
            {
                currentCoordinates = currentPoint.Y;
                destinationCoordinates = destination.Y;
                k = Math.Min(currentPoint.X, destination.X);
                m = Math.Max(currentPoint.X, destination.X);
            } else
            {
                currentCoordinates = currentPoint.X;
                destinationCoordinates = destination.X;
                k = Math.Min(currentPoint.Y, destination.Y);
                m = Math.Max(currentPoint.Y, destination.Y);
            }

            if(currentCoordinates == destinationCoordinates)
            {
                while(k <= m)
                {
                    xToCheck = mode == Accessibility.ROWS ? k : currentCoordinates;
                    yToCheck = mode == Accessibility.ROWS ? currentCoordinates : k;
                    result = this.IsAccessible(xToCheck, yToCheck);

                    if(!result)
                    {
                        break;
                    }

                    k++;
                }
            }

            return result;
        }

        public Object SearchMarker(Markers markerToFind)
        {
            Object result = null;
            
            foreach(List<BoardPoint> currentRow in this.currentGameBoard)
            {
                foreach(BoardPoint currentPoint in currentRow)
                {
                    if(currentPoint.Marker == markerToFind)
                    {
                        result = currentPoint;
                        break;
                    }
                }
            }
            return result;
        }

        public Object FindSpotLocation()
        {
            return this.SearchMarker(Markers.SPOT);
        }

        public Boolean IsSpotVisible(int x, int y)
        {
            Boolean result = false;
            Object currentPosition = this.GetItem(x, y);
            Object spotLocation = this.FindSpotLocation();

            if (spotLocation != null && currentPosition != null)
            {
                result = this.CheckAccessibility((BoardPoint)currentPosition, (BoardPoint)spotLocation, Accessibility.ROWS) || this.CheckAccessibility((BoardPoint)currentPosition, (BoardPoint)spotLocation, Accessibility.ROWS);
            }

            return result;
        }

        public Boolean ChangeItem(Markers markerToChange, Markers newMarker)
        {
            Boolean result = true;
            Object itemToChange = this.SearchMarker(markerToChange);

            if(itemToChange != null)
            {
                BoardPoint newItem = (BoardPoint)itemToChange;
                newItem.Marker = newMarker;
                this.SetItem(newItem);
            } else
            {
                result = false;
            }

            return result;
        }

        public void ChangeAllItems(Markers markerToChange, Markers newMarker)
        {
            Boolean result;

            do
            {
                result = this.ChangeItem(markerToChange, newMarker);
            } while (result);
        }

        public void ChangeAllItems(List<BoardPoint> points)
        {
            Boolean result;

            foreach(BoardPoint currentPoint in points)
            {
                result = this.SetItem(currentPoint);
                if (!result)
                {
                    break;
                }
            }
        }

        public void ResetItem(Markers markerToChange)
        {
            this.ChangeItem(markerToChange, Markers.ACCESSIBLE);
        }

        public void ResetItem(int x, int y)
        {
            this.SetItem(new BoardPoint(x, y, Markers.ACCESSIBLE));
        }

        public void ResetAllItems(Markers markerToChange)
        {
            this.ChangeAllItems(markerToChange, Markers.ACCESSIBLE);
        }

        public void SetSpotLocation(int x, int y)
        {
            this.ResetItem(Markers.SPOT);
            this.SetItem(new BoardPoint(x, y, Markers.SPOT));
        }
    }
}
