﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        private List<Point> PointList;

        public void Draw()
        {
            foreach (Point _point in PointList)
            {
                _point.Draw()
            }
        }
    }
}
