using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class RunningSnake:Figure
    {
        public RunningSnake(Point Tail, int Length, Direction _Direction)
        {
            PointList = new List<Point>();
            PointList.Add(Tail);
            Point NextPoint = Tail;
            if (_Direction == TOP)
            {
                for (y = 0; y < Length; y++)
                {
                    NextPoint = NextPoint.Move(_Direction);
                    PointList.Add(NextPoint);                    
                }
            }

            
        }
    }
}
