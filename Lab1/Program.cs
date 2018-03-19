using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Canvas canvas = new Canvas(60, 60);
            Eye eye1 = new AnimeEye(new SimpleDraw()),
                eye2 = new AnimeEye(new ReverseDraw());

            Ear ear1 = new ElphEar(new MirrorDraw()),
                ear2 = new ElphEar(new ReverseDraw());

            Skin skin = new SimpleSkin(new SimpleDraw());

            PhhotoRobot pr = new PhhotoRobot(canvas, skin, new List<Eye>(){eye1, eye2}, new List<Ear>(){ear1, ear2});
            

            Console.WriteLine(pr._canvas);
            Console.ReadKey();
        }
    }
}
