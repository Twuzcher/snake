using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            HorizontalLine downSide = new HorizontalLine(0, 78, 24, '+');
            downSide.draw();

            HorizontalLine upSide = new HorizontalLine(0, 78, 0, '+');
            upSide.draw();

            VerticalLine leftSide = new VerticalLine(0, 24, 0, '+');
            leftSide.draw();

            VerticalLine rightSide = new VerticalLine(0, 24, 78, '+');
            rightSide.draw();

            Point point = new Point(4, 5, '*');
            Snake snake = new Snake(point, 4, Direction.Right);

            snake.draw();
            snake.Move();

            Thread.Sleep(300);
            snake.Move();

            Console.ReadLine();
        }
    }
}
