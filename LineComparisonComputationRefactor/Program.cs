using System;

namespace LineComparisonComputationRefactor
{
    class Program
    {
        public static void LineComparison()
        {
            Console.WriteLine(" Welcome To Line Comparison Computation Program ");
            //Coordinates of Line1
            double x1x = Convert.ToDouble(Console.ReadLine());
            double y1x = Convert.ToDouble(Console.ReadLine());
            double x2x = Convert.ToDouble(Console.ReadLine());
            double y2x = Convert.ToDouble(Console.ReadLine());

            //Coordinates of Line2
            double x1y = Convert.ToDouble(Console.ReadLine());
            double y1y = Convert.ToDouble(Console.ReadLine());
            double x2y = Convert.ToDouble(Console.ReadLine());
            double y2y = Convert.ToDouble(Console.ReadLine());
            double squareXx = (x2x - x1x) * (x2x - x1x);
            double squareYx = (y2x - y1x) * (y2x - y1x);
            double squareXy = (x2y - x1y) * (x2y - x1y);
            double squareYy = (y2y - y1y) * (y2y - y1y);
            double lengthOfLine1 = Math.Sqrt(squareXx + squareYx);
            double lengthOfLine2 = Math.Sqrt(squareXy + squareYy);

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
            LineComparison();
        }
    }
}
