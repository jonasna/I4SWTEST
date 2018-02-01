using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion01.UnitTest.Old
{
    class CalculatorTest
    {
        static void Main(string[] args)
        {
            var calculator = new Lektion01.Calculator();

            Console.WriteLine("Add:");
            Console.WriteLine("Add({0},{1})\t = {2,7}", 5, 3, calculator.Add(5,3));
            Console.WriteLine("Add({0},{1})\t = {2,7}", 5, -3, calculator.Add(5, -3));
            Console.WriteLine("Add({0},{1})\t = {2,7}", -5, -3, calculator.Add(-5, -3));
            Console.WriteLine();

            Console.WriteLine("Subtract:");
            Console.WriteLine("Subtract({0},{1})\t = {2,7}", 5, 3, calculator.Subtract(5, 3));
            Console.WriteLine("Subtract({0},{1})\t = {2,7}", 5, -3, calculator.Subtract(5, -3));
            Console.WriteLine("Subtract({0},{1})\t = {2,7}", -5, -3, calculator.Subtract(-5, -3));
            Console.WriteLine();

            Console.WriteLine("Multiply:");
            Console.WriteLine("Multiply({0},{1})\t = {2,7}", 5, 3, calculator.Multiply(5, 3));
            Console.WriteLine("Multiply({0},{1})\t = {2,7}", 5, -3, calculator.Multiply(5, -3));
            Console.WriteLine("Multiply({0},{1})\t = {2,7}", -5, -3, calculator.Multiply(-5, -3));
            Console.WriteLine();

            Console.WriteLine("Power:");
            Console.WriteLine("Power({0},{1})\t = {2,7}", 5, 3, calculator.Power(5, 3));
            Console.WriteLine("Power({0},{1})\t = {2,7}", 5, -3, calculator.Power(5, -3));
            Console.WriteLine("Power({0},{1})\t = {2,7}", -5, -3, calculator.Power(-5, -3));
            Console.WriteLine();
        }
    }
}
