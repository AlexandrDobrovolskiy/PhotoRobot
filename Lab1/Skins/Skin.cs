using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    abstract class Skin : PartOfFace
    {
        public List<Point> EarsStartPoints { get; set; }
        public List<Point> EyesStartPoints { get; set; }
        public Point MouseStartPoint { get; set; }
        public Point NoseStartPoint { get; set; }
        public Point ConnectionPoint { get; set; }

    }
}
