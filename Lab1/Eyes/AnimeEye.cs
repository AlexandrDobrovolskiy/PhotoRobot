using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class AnimeEye : Eye
    {
        private readonly Canvas _image = new Canvas(new[,]
        {
            {1,1,1,1,1 },
            {1,0,1,0,1 },   
            {0,1,0,0,1 },
            {0,0,1,1,1 }
        });

        public AnimeEye(IDrawBehaviour db)
        {
            DrawBehaviour = db;
            Image = _image;
        }
         
        public AnimeEye()
        {
            DrawBehaviour = new SimpleDraw();
            Image = _image;
        }
    }
}
