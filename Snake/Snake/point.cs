using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        /* Класс состоит из
         * - данных
         * - конструкторов
         * - методов
         */
        public int x;
        public int y;
        public char symbol;

        public Point()
        {
        }

        public Point(int _x, int _y, char _symbol)
        {
            x = _x;
            y = _y;
            symbol = _symbol;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
        public void Move(Direction _Direction)
        {
            Point NewPoint = new Point(x, y, symbol);
            if (_Direction == TOP)
            {
                NewPoint.y--;
            }
            else if (_Direction == DOWN)
            {
                NewPoint.y++;
            }
            else if (_Direction == LEFT)
            {
                NewPoint.x--;
            }
            else if (_Direction == RIGHT)
            {
                NewPoint.x++;
            }
            return NewPoint;
        }
    }
}
