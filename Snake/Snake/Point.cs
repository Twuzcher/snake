using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char symb;

        public Point(int x, int y, char symb)
        {
            this.x = x;
            this.y = y;
            this.symb = symb;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            symb = p.symb;
        }

        public void Move(int offset, Direction direction)
        {
            switch (direction)
            {
                case Direction.Left:
                    x -= offset;
                    break;
                case Direction.Right:
                    x += offset;
                    break;
                case Direction.Up:
                    y -= offset;
                    break;
                case Direction.Down:
                    y += offset;
                    break;
            }
        }
        public void draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symb);
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + symb;
        }

        public void Clear()
        {
            symb = ' ';
            draw();
        }
    }
}