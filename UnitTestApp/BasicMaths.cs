using System;
using CalculatorLibrary;
namespace UnitTestApp
{
    //class Program
    //{
       class BasicMaths
        {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("Hello Welcometo your my Unit Test Application and this time date and time now {0}", DateTime.Now);
            Console.WriteLine("Sum of the value--> {0}",calculator.Add(15,20));
            Console.WriteLine("Substract of the value--> {0}", calculator.Substract(10, 2));
            Console.WriteLine("divide of the value--> {0}", calculator.divide(15, 20));
            Console.WriteLine("Multiply of the value--> {0}", calculator.Multiply(10, 2));
            Console.ReadKey();
        }
    }
    }
//}
