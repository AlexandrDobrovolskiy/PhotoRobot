using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class PhhotoRobot
    {
        public Canvas Canvas;
        public Skin Skin;
        public List<Ear> Ears;
        public List<Eye> Eyes;
        public Mouse Mouse;
        public Nose Nose;

        public PhhotoRobot(Canvas canvas, Skin skin, List<Ear> ears = null, List<Eye> eyes = null, Mouse mouse = null,
            Nose nose = null)
        {
            Canvas = canvas;
            Skin = skin;
            Ears = ears;
            Eyes = eyes;
            Mouse = mouse;
            Nose = nose;
            Update();

        }

        public void Update()
        {
            Skin.Draw(Canvas, Skin.ConnectionPoint);
            Mouse?.Draw(Canvas, Skin.MouseStartPoint);
            Nose?.Draw(Canvas, Skin.NoseStartPoint);
            int i = 0;

            if(Eyes != null)
                foreach (var eye in Eyes)
                {
                    eye.Draw( Canvas, Skin.EyesStartPoints[i]);
                    i++;
                }
            i = 0;

            if(Ears != null)
                foreach (var ear in Ears)
                {
                    ear.Draw( Canvas , Skin.EarsStartPoints[i]);
                    i++;
                }

        }
    }
}
