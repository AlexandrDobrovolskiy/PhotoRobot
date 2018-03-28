using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Mouses
{
    class HappyMouse : Mouse
    {
        private readonly Canvas _image = new Canvas(new[,]
        {
            {1,1,1,1,1,1,1,1,1,1,1 },
            {0,1,0,0,0,0,0,0,0,1,0 },
            {0,0,1,1,1,1,1,1,1,0,0 },

        });

        public HappyMouse(IDrawBehaviour db)
        {
            DrawBehaviour = db;
            Image = _image;
        }

        public HappyMouse()
        {
            DrawBehaviour = new SimpleDraw();
            Image = _image;
        }
    }
}
