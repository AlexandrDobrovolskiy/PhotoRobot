using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class PhhotoRobot
    {
        public Canvas _canvas;
        private Skin _skin;
        private List<Ear> _ears;
        private List<Eye> _eyes;
        private Mouse _mouse;
        private Nose _nose;

        public PhhotoRobot(Canvas canvas, Skin skin, List<Ear> ears, List<Eye> eyes, Mouse mouse, Nose nose)
        {
            _canvas = canvas;
            _skin = skin;
            _ears = ears;
            _eyes = eyes;
            _mouse = mouse;
            _nose = nose;

        }

        public PhhotoRobot(Canvas canvas, Skin skin, List<Eye> eyes, List<Ear> ears)
        {
            _eyes = eyes;
            _canvas = canvas;
            _ears = ears;
            _skin = skin;
            Update();
        }

        public void Update()
        {
            _skin.Draw(_canvas, new Point(_skin.ConnectionPoint.PosY,_skin.ConnectionPoint.PosX));
            int i = 0;
            foreach (var eye in _eyes)
            {
                eye.Draw( _canvas, _skin.EyesStartPoints[i]);
                i++;
            }
            i = 0;
            foreach (var ear in _ears)
            {
                ear.Draw( _canvas , _skin.EarsStartPoints[i]);
                i++;
            }

        }
    }
}
