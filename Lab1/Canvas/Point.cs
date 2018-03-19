using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Point
    {
        public int PosX { get; set; }
        public int PosY { get; set; }

        public Point(int posY, int posX)
        {
            PosX = posX;
            PosY = posY;
        }
    }
}
