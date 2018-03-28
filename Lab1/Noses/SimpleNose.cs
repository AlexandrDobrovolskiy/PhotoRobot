using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Noses
{
    class SimpleNose : Nose
    {
        private readonly Canvas _image = new Canvas(new[,]
        {
            {0,1,1,1,0 },
            {1,0,0,0,1 },
            {1,0,0,0,1 },
            {0,1,1,1,0 }
        });

        public SimpleNose(IDrawBehaviour db)
        {
            DrawBehaviour = db;
            Image = _image;
        }
         
        public SimpleNose()
        {
            DrawBehaviour = new SimpleDraw();
            Image = _image;
        }
    }
}
