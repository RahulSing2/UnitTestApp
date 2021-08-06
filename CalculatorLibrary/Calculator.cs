using System;
using CalculatorLibrary;
namespace CalculatorLibrary
{
     public class Calculator 
    {
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public double Substract(double num1, double num2)
        {
            return num1 - num2;
        }
        public double divide(double num1, double num2)
        {
            //double result = num1 / num2;
           // return result;
            return num1 / num2;
        }
        public double Multiply(double num1, double num2)
        {
            // To trace error while testing, writing + operator instead of * operator.  
            return num1 * num2;
        }
    }
}
