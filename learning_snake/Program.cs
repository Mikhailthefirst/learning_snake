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
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            Point p3 = new Point(7, 5, 'x');
            p2.Draw();

            Point p4 = new Point(44, 14, 'r');
            p2.Draw();

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);
            Console.WriteLine("");

            List<string> oda = new List<string>();
            oda.Add("Однажны в студеную зимнюю пору");
            oda.Add("Я из лесу вышел, был сильный мороз");
            oda.Add("Гляжу");
            oda.Add("Лошадка");

            foreach(string i in oda)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine(oda[3]);
            Console.WriteLine(oda[2]);
            Console.WriteLine(oda[0]);
            Console.WriteLine(oda[1]);

            //foreach(Point i in pList)
            //{
            //    Console.WriteLine(i);
            //}


            Console.ReadLine();
        }

    }
}
