using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProRectangle
{
    public class Rectangle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { set; get; }
        public int Height { set; get; }
        public ConsoleColor Color { set; get; }

        public Rectangle()
        {

        }
        public Rectangle(int x, int y, int width, int height, ConsoleColor cl)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Color = cl;
        }
        public void DrawOrClean(bool draw)
        {
            Console.ForegroundColor = draw ? Color : Console.BackgroundColor;

            Console.SetCursorPosition(X, Y);
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
                Console.CursorLeft = X;
            }

            Console.ResetColor();
        }
        public static Rectangle operator ++(Rectangle rec)
        {
            rec.X++;

            return rec;
        }
        public void Top()
        {
            Y--;
        }
        public void Bottom()
        {
            Y++;
        }

        public override string ToString()
        {
            return $"{X}\t{Y}\t{Color}";
        }
    }
}
