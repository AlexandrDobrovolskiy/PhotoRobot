using System;
using System.Linq;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Canvas canvas = new Canvas(40, 40);
            Eye eye1 = new AnimeEye(),
                eye2 = new AnimeEye(new ReverseDraw());

            eye1.Draw(canvas, new Point(3,3));
            eye2.Draw(canvas, new Point(3,13));
            

            Console.WriteLine(canvas);
            Console.ReadKey();
        }
    }
}
