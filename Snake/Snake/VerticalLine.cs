using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine: Figure
    {
        public VerticalLine(int x, int yTop, int yDown, char symbol)
        {
            PointList = new List<Point>();
            for (int y = yTop; y <= yDown; y++)
            {
                Point newpoint = new Point(x, y, symbol);
                PointList.Add(newpoint);
            }
        }
    }
}
