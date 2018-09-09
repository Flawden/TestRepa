using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitProject
{
    class Program
    {
        static void Main(string[] args)
        {

            //Отрисовка линии
            HorizontalLine xlineUp = new HorizontalLine(1, 118, 0, '*');
            HorizontalLine xlineDown = new HorizontalLine(1, 118, 29, '*');
            VerticalLine ylineLeft = new VerticalLine(0, 29, 0, '*');
            VerticalLine ylineRight = new VerticalLine(0, 29, 118, '*');
            xlineUp.Drow();
            xlineDown.Drow();
            ylineLeft.Drow();
            ylineRight.Drow();

            //Отрисовка точек
            Point p = new Point(8, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            Console.ReadKey();
        }

      
    }
}
