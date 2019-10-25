using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace ProRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle(5 , 5 , 16 , 8 , ConsoleColor.Green);
            WriteLine(rec);
            rec.DrawOrClean(true);
            Thread.Sleep(1500);
            rec.DrawOrClean(false);
            rec++;
            WriteLine(rec);
            rec.DrawOrClean(true);
            Thread.Sleep(1500);
            rec.DrawOrClean(false);
            WriteLine();
        }
    }
}