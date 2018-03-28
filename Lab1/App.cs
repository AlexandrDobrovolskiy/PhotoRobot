using System;
using System.Collections.Generic;
using System.Text;
using Lab1.Eyes;
using Lab1.Mouses;
using Lab1.Noses;

namespace Lab1
{
    static class App
    {
        public static void Start()
        {
            //sample init
            IDrawBehaviour simple = new SimpleDraw(),
                mirror = new MirrorDraw(),
                reverse = new ReverseDraw();

            Canvas canvas = new Canvas(60, 60);
            Eye eye1 = new SimpleEye(),
                eye2 = new SimpleEye(reverse);

            Ear ear1 = new SimpleEar(mirror),
                ear2 = new SimpleEar(reverse);

            Skin skin = new SimpleSkin(simple);

            PhhotoRobot pr = new PhhotoRobot(canvas, skin, eyes: new List<Eye>() { eye1, eye2 }, ears: new List<Ear>() { ear1, ear2 }, mouse: new SadMouse(), nose: new SimpleNose());

            

            //game
            while (true)
            {
                Console.WriteLine(pr.Canvas);
                Console.WriteLine("Welcome ! This is Photorobot =) to change this face use commands like <{Name} {Part} {flag}(optional)>");
                string[] input = Console.ReadLine()?.Split(' ');
                Console.Clear();
                
                if (input != null)
                    switch (input[0])
                    {
                        case "eye":
                            switch (input[1])
                            {
                                case "anime":
                                    if(input[2].Contains("r")) pr.Eyes[1] = new AnimeEye(reverse);
                                    else pr.Eyes[0] = new AnimeEye();
                                    break;
                                case "simple":
                                    if (input[2].Contains("r")) pr.Eyes[1] = new SimpleEye(reverse);
                                    else pr.Eyes[0] = new SimpleEye();
                                    break;
                            }
                            break;
                        case "ear":
                            switch (input[1])
                            {
                                case "elph":
                                    if (input[2].Contains("r")) pr.Ears[1] = new ElphEar(reverse);
                                    else pr.Ears[0] = new ElphEar(mirror);
                                    break;
                                case "simple":
                                    if (input[2].Contains("r")) pr.Ears[1] = new SimpleEar(reverse);
                                    else pr.Ears[0] = new SimpleEar(mirror);
                                    break;
                            }
                            break;
                        case "nose":
                            case "anime":
                                pr.Nose = new AnimeNose();
                                break;
                            case "simple":
                                pr.Nose = new SimpleNose();
                                break;
                            break;
                        case "mouse":
                            switch (input[1])
                            {
                                case "happy":
                                    pr.Mouse = new HappyMouse();
                                    break;
                                case "sad":
                                    pr.Mouse = new SadMouse();
                                    break;
                            }
                            break;
                        default:
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine(" !!!!!!  Invalid command  !!!!!!!");
                            Console.BackgroundColor = ConsoleColor.Black;
                            break;
                    }
                pr.Update();
            }
        }
    }
}
