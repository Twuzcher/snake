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

            HorizontalLine hLine = new HorizontalLine(5, 10, 8, '+');
            hLine.draw();

            VerticalLine vLine = new VerticalLine(3, 8, 11, '+');
            vLine.draw();

            Console.ReadLine();
        }
    }
}
