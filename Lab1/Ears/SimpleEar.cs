using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class SimpleEar :  Ear
    {
        public SimpleEar(IDrawBehaviour db)
        {
            DrawBehaviour = db;
            Image = new Canvas(new[,]
            {
                {1,1,1,1 },
                {1,0,0,0 },
                {1,0,0,0 },
                {1,0,0,0 },
                {1,0,0,0 },
                {1,0,0,0 },
                {1,0,0,0 },
                {1,0,0,0 },
                {1,0,0,0 },
                {1,1,1,1 }

            });
        }
    }
}
