using System;

namespace NumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the rectangle.");
            string lengthInput = Console.ReadLine();
            double rectanglelength= double.Parse(lengthInput);
            Console.WriteLine("Enter the width of the rectangle.");
            string widthInput = Console.ReadLine();
            double rectanglewidth = double.Parse(widthInput);
            double rectangleArea = rectanglelength * rectanglewidth;
            Console.WriteLine("The area of the rectangle is " + rectangleArea);
        }
    }
}
