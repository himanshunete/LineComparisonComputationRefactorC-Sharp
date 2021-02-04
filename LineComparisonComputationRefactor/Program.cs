using System;

namespace LineComparisonComputationRefactor
{

    class Points
    {
        double x1x;
        double y1x;
        double x2x;
        double y2x;
        double x1y;
        double y1y;
        double x2y;
        double y2y;
        public Points(double x1x, double y1x, double x2x, double y2x, double x1y, double y1y, double x2y, double y2y)
        {
            this.x1x = 0;
            this.y1x = 0;
            this.x2x = 0;
            this.y2x = 0;
            this.x1y = 0;
            this.y1y = 0;
            this.x2y = 0;
            this.y2y = 0;

        }
    }
    class Program
    {
      

        public static void LineComparison(double x1x, double y1x, double x2x, double y2x, double x1y, double y1y, double x2y, double y2y)
        {

            double squareX1 = (x2x - x1x) * (x2x - x1x);
            double squareY1 = (y2x - y1x) * (y2x - y1x);
            double squareX2 = (x2y - x1y) * (x2y - x1y);
            double squareY2 = (y2y - y1y) * (y2y - y1y);
            double lengthOfLine1 = Math.Sqrt(squareX1 + squareY1);
            double lengthOfLine2 = Math.Sqrt(squareX2 + squareY2);

            if (lengthOfLine1 == lengthOfLine2)
            {
                Console.WriteLine("Length of Two Lines are Equal");
            }
            else if (lengthOfLine1 > lengthOfLine2)
            {
                Console.WriteLine("Length of Line1 is Greater than Line 2 ");
            }

            else if (lengthOfLine1 < lengthOfLine2)
            {
                Console.WriteLine("Length of Line1 is lesser than Line 2 ");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome To Line Comparison Computation Program ");
            double x1x = Convert.ToDouble(Console.ReadLine());
            double y1x = Convert.ToDouble(Console.ReadLine());
            double x2x = Convert.ToDouble(Console.ReadLine());
            double y2x = Convert.ToDouble(Console.ReadLine());
            double x1y = Convert.ToDouble(Console.ReadLine());
            double y1y = Convert.ToDouble(Console.ReadLine());
            double x2y = Convert.ToDouble(Console.ReadLine());
            double y2y = Convert.ToDouble(Console.ReadLine());

            LineComparison(x1x, y1x, x2x, y2x, x1y, y1y, x2y, y2y);

        }
    }
}
