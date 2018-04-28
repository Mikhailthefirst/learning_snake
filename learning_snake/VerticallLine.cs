using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_snake
{
    class VerticallLine
    {
        List<Point> pList;

        public VerticallLine(int yTop, int yBottom, int x, char sym)
        {
            pList = new List<Point>();
            for(int y = yTop; y <= yBottom; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public void Draw()
        {
            foreach(Point i in pList)
            {
                i.Draw();
            }
        }
    }
}
