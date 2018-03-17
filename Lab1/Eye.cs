using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    abstract class Eye : PartOfFace
    {
        public override void Draw(Canvas canvas, Point startPoint)
        {
            DrawBehaviour.Draw(canvas, Image, startPoint);
        }
    }
}
