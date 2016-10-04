using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class RunningSnake:Figure
    {
        public RunningSnake(Point Tail, int Length, Direction direction)
        {
            PointList = new List<Point>();
            PointList.Add(Tail);
            Point NextPoint = Tail;
            for (int i = 1; i < Length; i++)
            {
                NextPoint = NextPoint.Move(direction);
                PointList.Add(NextPoint);
            }
                                   
        }

        
        piblic void Move()
        {
            
        }
    }
}
