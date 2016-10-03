﻿using System;
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
            for (int x = xLeft; x <= xRight; x++)
            {
                Point newpoint = new Point(x, y, symbol);
                PointList.Add(newpoint);
            }
        }
    }
}
