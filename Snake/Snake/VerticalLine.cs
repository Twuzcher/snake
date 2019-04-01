using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        List<Point> points;

        public VerticalLine(int yDown, int yHigh, int x, char symb)
        {
            points = new List<Point>();
            for (int y = yDown; y <= yHigh; y++)
            {
                Point point = new Point(x, y, symb);
                points.Add(point);
            }
        }

        public void draw()
        {
            foreach (Point point in points)
            {
                point.draw();
            }
        }
    }
}
