using System;

namespace Test04Feature533
{
    class Program
    {
        static void Main(string[] args)
        {
            Point ulcq = new Point();
            ulcq.CoordinateX = 11;
            ulcq.CoordinateY = 5;
            Point lrcq = new Point();
            lrcq.CoordinateX = 15;
            lrcq.CoordinateY = 1;
            Point ulcr = new Point();
            ulcr.CoordinateX = 1;
            ulcr.CoordinateY = 4;
            Point lrcr = new Point();
            lrcr.CoordinateX = 6;
            lrcr.CoordinateY = 1;
            Square quadrat = new Square();
            quadrat.UpperLeftCorn = ulcq;
            quadrat.LowerRightCorn = lrcq;
            Rectangle rectangle = new Rectangle();
            rectangle.UpperLeftCorn = ulcr;
            rectangle.LowerRightCorn = lrcr;
            Console.WriteLine(quadrat.ToString());
            Console.WriteLine(rectangle.ToString());
        }
    }
}
