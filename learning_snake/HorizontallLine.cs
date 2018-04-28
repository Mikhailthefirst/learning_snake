﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_snake
{
    class HorizontallLine
    {
        List<Point> pList;

        public HorizontallLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for(int x = xLeft; x <= xRight; x++)
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
