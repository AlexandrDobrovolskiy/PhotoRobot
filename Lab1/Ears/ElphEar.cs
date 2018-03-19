using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class ElphEar : Ear
    {
        public ElphEar(IDrawBehaviour db)
        {
            DrawBehaviour = db;
            Image = new Canvas(new[,]
            {
                {1,1,0,0 },
                {1,0,1,0 },
                {1,0,1,0 },
                {0,1,0,1 },
                {0,1,0,0 },
                {0,1,0,0 },
                {0,0,1,0 },
                {0,0,1,0 },
                {0,0,1,0 },
                {0,0,0,1 }

            });
        }
    }
}
