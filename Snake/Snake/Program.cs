﻿using System;
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
            Point point_1 = new Point();
            point_1.x = 2;
            point_1.y = 2;
            point_1.symb = '*';
            point_1.draw();
            Console.ReadLine();
        }
    }
}
