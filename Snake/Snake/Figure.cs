using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Point> points;

        public void draw()
        {
            foreach (Point point in points)
            {
                point.draw();
            }
        }
    }
}
