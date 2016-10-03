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
            string mode = "HorizontalLine";

            if (mode == "HorizontalLine")
            {
                HorizontalLine hr = new HorizontalLine(10, 15, 3, '#');
                VerticalLine vr = new VerticalLine(4, 1, 10, '$');
                hr.Draw();
                vr.Draw();
                
            }
            else
            {
                Point p1 = new Point(10, 4, '*');
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
            }  
            Console.ReadLine();
        }
    }
}
