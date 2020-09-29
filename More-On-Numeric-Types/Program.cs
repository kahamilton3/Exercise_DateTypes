using System;

namespace More_On_Numeric_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many miles have you driven?");
            string milesInput = Console.ReadLine();
            double milesDriven = double.Parse(milesInput);
            Console.WriteLine("How much gas have you consumed in gallons?");
            string gasInput = Console.ReadLine();
            double gasGallons = double.Parse(gasInput);
            double milesPerGallon = milesDriven / gasGallons;
            Console.WriteLine("Your miles-per-gallon is " + milesPerGallon + ".");
        }
    }
}
