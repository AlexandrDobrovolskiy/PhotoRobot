using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    abstract class PartOfFace : IDrawble
    {
        protected Canvas Image;
        protected IDrawBehaviour DrawBehaviour;

        public void Draw(Canvas canvas, Point startPoint)
        {
            DrawBehaviour.Draw(canvas, Image, startPoint);
        }
    }
}
