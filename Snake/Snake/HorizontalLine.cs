using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine: Figure
    {
        public HorizontalLine(int x1, int x2, int y, char symbol)
        {
            for (int i = x1, i <= x2, i++)
            {
                Point point = 
                PointList.Add(new Point(i, y, symbol));
            }
        }
    }
}
