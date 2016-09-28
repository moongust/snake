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
            Point p1 = new Point(10,4,'*');
            Point p2 = new Point(10, 5, '*');

            p1.Draw();
            p2.Draw();

            List<int> numlist = new List<int>();
            numlist.Add(24);
            numlist.Add(48);
            numlist.Add(96);

            foreach (int i in numlist)
            {
                Console.WriteLine(i);
            }
            

            /* p1.x = 10;
            p1.y = 4;
            p1.symbol = '*';
            Console.SetCursorPosition(x1, y1);
            Console.Write(symbol);
            Console.WriteLine("Hello, world!");
             */ 
            
            Console.ReadLine();
        }
    }
}
