using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.IO;
using Agostinelli.src.gameboard;
using System.Reflection;

namespace Agostinelli.test.gameboard
{
    class GameBoardTest
    {
        private GameBoard testBoard;

        [SetUp]
        public void SetUp()
        {
            int r = 0;
            List<List<String>> mapLayout = new List<List<String>>();
            StreamReader reader = new StreamReader(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "//TestBoard.txt");
            while (!reader.EndOfStream)
            {
                String line = reader.ReadLine();
                mapLayout.Add(new List<String>());
                foreach(char value in line)
                {
                    mapLayout.ElementAt(r).Add(value.ToString());
                }
                r++;
            }
            reader.Close();
            testBoard = new GameBoard(mapLayout);
        }

        [Test]
        public void SpotNotVisible()
        {
            Assert.IsFalse(this.testBoard.IsSpotVisible(1, 7));
        }

        [Test]
        public void SpotVisible()
        {
            List<BoardPoint> positions = new List<BoardPoint>();
            for(int i = 3; i <= 6; i++)
            {
                positions.Add(new BoardPoint(i, 1, Markers.ACCESSIBLE));
            }

            this.testBoard.ChangeAllItems(positions);
            Assert.IsTrue(this.testBoard.IsSpotVisible(1, 7));
        }
    }
}
