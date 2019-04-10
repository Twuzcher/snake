using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        public Direction direction;

        public Snake(Point tail, int lenght, Direction direction)
        {
            points = new List<Point>();
            this.direction = direction;

            for (int i = 0; i < lenght; i++)
            {
                Point point = new Point(tail);
                point.Move(i, direction);
                points.Add(point);
            }
        }

        internal void Move()
        {
            Point tail = points.First();
            points.Remove(tail);
            Point head = GetNextPoint();
            points.Add(head);
            tail.Clear();
            head.draw();
        }

        public Point GetNextPoint()
        {
            Point head = points.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }
    }
}
