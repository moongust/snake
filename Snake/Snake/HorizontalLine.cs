using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine: Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, char symbol)
        {
            PointList = new List<Point>();                        
            for (int _x = xLeft; _x <= xRight; _x++)
            {
                Point newpoint = new Point(_x, y, symbol);
                PointList.Add(newpoint);
            }
        }
    }
}
