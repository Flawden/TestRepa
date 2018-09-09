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
            Point p1 = new Point(1, 3, '*');
            Point p2 = new Point(4, 5, '#');

            p1.Draw();
            p2.Draw();

            HorizontalLine xlineUp = new HorizontalLine(1, 100, 0, '-');
            HorizontalLine xlineDown = new HorizontalLine(1, 100, 35, '-');
            VerticalLine ylineLeft = new VerticalLine(0, 35, 0, '+');
            VerticalLine ylineRight = new VerticalLine(0, 35, 100, '+');
            xlineUp.Drow();
            xlineDown.Drow();
            ylineLeft.Drow();
            ylineRight.Drow();
            

            Console.ReadKey();
        }

      
    }
}
