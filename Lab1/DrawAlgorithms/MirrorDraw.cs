using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class MirrorDraw : IDrawBehaviour
    {
        public void Draw(Canvas canvas, Canvas imageCanvas, Point startPoint)
        {
            for (int i = 0; i < imageCanvas.Height; i++)
            {
                for (int j = imageCanvas.Width - 1; j >= 0; j--)
                {
                    canvas.Cells[startPoint.PosY + i, startPoint.PosX - j] = imageCanvas.Cells[i, Math.Abs(imageCanvas.Width - j - 1)];
                }
            }
        }
    }
}
