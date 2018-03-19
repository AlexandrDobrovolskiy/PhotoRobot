using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class SimpleDraw : IDrawBehaviour
    {
        public void Draw(Canvas canvas, Canvas imageCanvas, Point startPoint)
        {
            for (int i = 0; i < imageCanvas.Height; i++)
            {
                for (int j = 0; j < imageCanvas.Width; j++)
                {
                    canvas.Cells[i + startPoint.PosY, j + startPoint.PosX] = imageCanvas.Cells[i, j];
                }
            }
        }
    }
}
