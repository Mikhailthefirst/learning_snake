using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_snake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls (int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            //рама 120*30
            // HorizontallLine topLine = new HorizontallLine(0, 78, 0, '+');
            //HorizontallLine bottomLine = new HorizontallLine(0, 78, 24, '+');
            //VerticallLine leftLine = new VerticallLine(0, 24, 0, '+');
            //VerticallLine rightLine = new VerticallLine(0, 24, 78, '+');
            HorizontallLine topLine = new HorizontallLine(0, mapWidth - 2, 0, '+');
            HorizontallLine bottomLine = new HorizontallLine(0, mapWidth - 2, mapHeight - 1, '+');
            VerticallLine leftLine = new VerticallLine(0, mapHeight - 1, 0, '+');
            VerticallLine rightLine = new VerticallLine(0, mapHeight - 1, mapWidth - 2, '+');

            //topLine.Draw();
            //bottomLine.Draw();
            //leftLine.Draw();
            //rightLine.Draw();

            wallList.Add(topLine);
            wallList.Add(bottomLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }

        internal bool IsHit(Figure snake)
        {
           foreach(var wall in wallList)
            {
                if (wall.IsHit(snake))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach(var wall in wallList)
            {
                wall.Draw();
            }
        }

    }
}
