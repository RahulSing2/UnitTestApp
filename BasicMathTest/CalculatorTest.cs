using System;
using Xunit;
using CalculatorLibrary;
namespace BasicMathTest
{
    public class CalculatorTest
    {
        [Fact]
        public void Test_Add()
        {
            int excepted = 24;
            int a = 20;
            int b = 4;
            Calculator compair = new Calculator();
            double rest = compair.Add(20, 4);
            Assert.Equal(rest, excepted);
        }
        [Fact]
        public void Test_Substract() 
        {
            int excepted = 16;
            int a = 20;
            int b = 4;
            Calculator compair = new Calculator();
            double rest = compair.Substract(20, 4);
            Assert.Equal(rest, excepted);
        }
        [Fact]
        public void Test_Multiply() 
        {
            int excepted = 80;
            int a = 20;
            int b = 4;
            Calculator compair = new Calculator();
            double rest = compair.Multiply(20, 4);
            Assert.Equal(rest, excepted);
        }
        [Fact]
        public void Test_Devide()
        {
            int excepted = 5;
            int a = 20;
            int b = 4;
            Calculator compair = new Calculator();
            double rest = compair.divide(20, 4);
            Assert.Equal (rest,excepted);
        }

    }
}
