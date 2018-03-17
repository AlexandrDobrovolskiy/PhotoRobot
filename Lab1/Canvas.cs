using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Canvas
    {
        public int[,] Cells { get; set; }

        public int Width { get; set; }
        public int Height { get; set; }

        public Canvas(int width, int height)
        {
            Width = width;
            Height = height;
            GenerateEmpty();
        }

        public Canvas(int[,] array)
        {
            Cells = array;
            Width = array.GetLength(1);
            Height = array.GetLength(0);
        }

        private void GenerateEmpty()
        {
            Cells = new int[Height, Width];
            for (int rowIndex = 0; rowIndex < Height; rowIndex++)
            {
                for (int colIndex = 0; colIndex < Width; colIndex++)
                {
                    Cells[rowIndex, colIndex] = 0;
                }
            }
        }

        public override string ToString()
        {
            string image = String.Empty;
            for (int rowIndex = 0; rowIndex < Height; rowIndex++)
            {
                for (int colIndex = 0; colIndex < Width; colIndex++)
                {
                    image += Cells[rowIndex, colIndex] == 0 ? " " : "*";
                }

                image += "\n";
            }

            return image;
        }
    }
}
