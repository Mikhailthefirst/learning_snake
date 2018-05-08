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
            Console.SetBufferSize(80, 25);

            //рама
            HorizontallLine topLine = new HorizontallLine(0, 78, 0, '+');
            HorizontallLine bottomLine = new HorizontallLine(0, 78, 24, '+');
            VerticallLine leftLine = new VerticallLine(0, 24, 0, '+');
            VerticallLine rightLine = new VerticallLine(0, 24, 78, '+');

            topLine.Draw();
            bottomLine.Draw();
            leftLine.Draw();
            rightLine.Draw();


            //и точка
            Point p = new Point(4, 5, '*');
            p.Draw();

       

            Console.ReadLine();
        }

    }
}
