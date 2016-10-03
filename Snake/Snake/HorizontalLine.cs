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
            
            for (int x = xLeft, i <= xRight, i++)
            {
                Point newpoint = new Point(x, y, symbol)
                PointList.Add(newpoint);
            }
        }
    }
}
