using System;

namespace FractionProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
           
            Fraction f1 = new Fraction();
            Console.WriteLine($"Default: {f1.GetFractionString()} = {f1.GetDecimalValue()}");

            
            Fraction f2 = new Fraction(5);
            Console.WriteLine($"Whole Number: {f2.GetFractionString()} = {f2.GetDecimalValue()}");

           
            Fraction f3 = new Fraction(3, 4);
            Console.WriteLine($"Fraction: {f3.GetFractionString()} = {f3.GetDecimalValue()}");

           
            f3.SetTop(1);
            f3.SetBottom(3);
            
            Console.WriteLine("\nAfter using Setters:");
            Console.WriteLine($"New Fraction: {f3.GetFractionString()}");
            Console.WriteLine($"New Decimal: {f3.GetDecimalValue()}");

            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

}