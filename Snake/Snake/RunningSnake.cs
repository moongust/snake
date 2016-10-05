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
        /* Constructor, Create and Draw new linear Snake from tail point. */
        {
            PointList = new List<Point>();
            PointList.Add(Tail);
            Point NextPoint = Tail;
            for (int i = 1; i < Length; i++)
            {
                NextPoint = NextPoint.CopyShift(direction);
                PointList.Add(NextPoint);
            }
            Draw();                       
        }

        /* Змейка создаётся и сразу рисуется. При перемещении удаляется и затирается первая
         *  (хвостовая) клетка, создаётся новая головная клетка как сдвиг последней клетки в направлении Direction */        
        public void Move(Direction direction)
        {
            
        }


    }
}
