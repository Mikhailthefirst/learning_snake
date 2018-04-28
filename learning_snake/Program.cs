using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point p1 = new Point(1, 3, '*');
            //p1.Draw();

            //Point p2 = new Point(4, 5, '#');
            //p2.Draw();

            //Point p3 = new Point(7, 5, 'x');
            //p3.Draw();

            //Point p4 = new Point(44, 14, 'r');
            //p4.Draw();

            HorizontallLine HLine = new HorizontallLine(4, 60, 5, '*');
            HLine.Draw();

            VerticallLine VLine = new VerticallLine(1, 20, 19, 'x');
            VLine.Draw();

            Console.ReadLine();
        }

    }
}
