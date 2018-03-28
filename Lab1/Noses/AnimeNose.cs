using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Noses
{
    class AnimeNose : Nose
    {
        private readonly Canvas _image = new Canvas(new[,]
        {
            {0,0,1,0,0 },
            {0,0,0,1,0 },
            {0,0,0,0,1 },
            {0,1,1,1,1 }
        });

        public AnimeNose(IDrawBehaviour db)
        {
            DrawBehaviour = db;
            Image = _image;
        }

        public AnimeNose()
        {
            DrawBehaviour = new SimpleDraw();
            Image = _image;
        }
    }
}
