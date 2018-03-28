using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Mouses
{
    class SadMouse : Mouse
    {
        private readonly Canvas _image = new Canvas(new[,]
        {
            {0,0,1,1,1,1,1,1,1,0,0 },
            {0,1,0,0,0,0,0,0,0,1,0 },
            {1,1,1,1,1,1,1,1,1,1,1 },

        });

        public SadMouse(IDrawBehaviour db)
        {
            DrawBehaviour = db;
            Image = _image;
        }

        public SadMouse()
        {
            DrawBehaviour = new SimpleDraw();
            Image = _image;
        }
    }
}
