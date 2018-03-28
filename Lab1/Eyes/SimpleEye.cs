using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Eyes
{
    class SimpleEye : Eye
    {
        private readonly Canvas _image = new Canvas(new[,]
        {
            {0,1,1,1,0 },
            {1,0,1,0,1 },
            {1,0,0,0,1 },
            {0,1,1,1,0 }
        });

        public SimpleEye(IDrawBehaviour db)
        {
            DrawBehaviour = db;
            Image = _image;
        }

        public SimpleEye()
        {
            DrawBehaviour = new SimpleDraw();
            Image = _image;
        }
    }
}
