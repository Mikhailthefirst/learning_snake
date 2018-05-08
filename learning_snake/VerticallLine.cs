using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_snake
{
    class VerticallLine : Figure
    {
        public VerticallLine(int yTop, int yBottom, int x, char sym)
        {
            pList = new List<Point>();
            for(int y = yTop; y <= yBottom; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

    }
}
