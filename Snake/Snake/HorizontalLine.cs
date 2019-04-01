using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine
    {
        List<Point> points;

        public HorizontalLine(int xLeft, int xRight, int y, char symb)
        {
            points = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
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
