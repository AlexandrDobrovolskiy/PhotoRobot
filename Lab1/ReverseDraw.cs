using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class ReverseDraw : IDrawBehaviour
    {
        public void Draw(Canvas canvas, Canvas imageCanvas, Point startPoint)
        {
            for (int i = 0; i < imageCanvas.Height; i++)
            {
                int k = 0;
                for (int j = imageCanvas.Width - 1; j >= 0; j--)
                {
                    canvas.Cells[i + startPoint.PosY, k + startPoint.PosX] = imageCanvas.Cells[i, j];
                    k++;
                }
            }
        }
    }
}
