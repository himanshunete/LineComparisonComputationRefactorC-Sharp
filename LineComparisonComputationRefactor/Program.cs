using System;

namespace LineComparisonComputationRefactor
{
    class Program
    {
        public static void LineComparison()
        {
            Console.WriteLine(" Welcome To Line Comparison Computation Program ");
            //Coordinates
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());

            double squareX = (x2 - x1) * (x2 - x1);
            double squareY = (y2 - y1) * (y2 - y1);
            Console.WriteLine($" Length of a Line: { Math.Sqrt(squareX + squareY) }");
        }

        static void Main(string[] args)
        {
            LineComparison();
        }
    }
}
