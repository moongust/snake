using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            HorizontalLine hr = new HorizontalLine(1, 15, 1, '#');
            VerticalLine vr = new VerticalLine(1, 1, 15,'#');
            hr.Draw();
            vr.Draw();
            RunningSnake rs1 = new RunningSnake(new Point(3, 3, 'D'), 5, Direction.DOWN);
            RunningSnake rs2 = new RunningSnake(new Point(5, 5, '*'), 8, Direction.DOWN);

            List<Direction> DirList = new List<Direction> {Direction.LEFT,Direction.LEFT,Direction.LEFT,
                Direction.DOWN,Direction.DOWN,Direction.RIGHT,Direction.TOP,Direction.RIGHT,
                Direction.RIGHT,Direction.RIGHT,Direction.RIGHT,Direction.RIGHT,Direction.DOWN,
                Direction.DOWN};

            foreach (Direction d in DirList)
            {
                rs2.Move(d);
                System.Threading.Thread.Sleep(500);
            }
            Console.ReadLine();
        }
    }
}
