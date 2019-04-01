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
            Point point_1 = new Point(2, 2, '*');
            point_1.draw();

            Point point_2 = new Point(3, 3, '#');
            point_2.draw();

            point_2 = new Point(4, 4, '$');
            point_1 = point_2;

            point_1.draw();
            point_2.draw();

            myFunc(point_2);
            point_1.draw();
            point_2.draw();

            Console.ReadLine();
            Console.Clear();
            point_1 = new Point(2, 2, '*');
            point_2 = new Point(2, 3, '*');

            List<Point> points = new List<Point>();
            points.Add(point_1);
            points.Add(point_2);

            foreach (Point p in points)
            {
                p.draw();
            }

            Console.ReadLine();
            Console.Clear();

            points.RemoveAt(0);

            foreach (Point p in points)
            {
                p.draw();
            }

            Console.ReadLine();
        }

        static void myFunc(Point point)
        {
            point.x = 5;
            point.y = 5;
            point.symb = '%';
        }
    }
}
