using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDemo
{
    [TestFixture]
    class MyCalculatorTest
    {
        [TestCase(-0, -0)]
        [TestCase(0, 0)]
        [TestCase(11111111111111111111, 11111111111111111111)]
        [TestCase(-12.11111111111111111111, -111111111111.11111111)]
        [TestCase(-2.555555555, 2244)]
        [TestCase(2244, 0)]
        public void Add(double a, double b)
        {
            double x = a, y = b;
            MyCalculator my = new MyCalculator();
            Assert.AreEqual(x+y,my.Add(x,y));
        }

        [TestCase(-0, -0)]
        [TestCase(0, 0)]
        [TestCase(11111111111111111111, 11111111111111111111)]
        [TestCase(-12.11111111111111111111, -111111111111.11111111)]
        [TestCase(-2.555555555, 2244)]
        [TestCase(2244, 0)]
        public void Subtract(double a, double b)
        {
            double x = a, y = b;
            MyCalculator my = new MyCalculator();
            Assert.AreEqual(x - y, my.Subtract(x, y));
        }

        [TestCase(-0, -0)]
        [TestCase(0, 0)]
        [TestCase(11111111111111111111, 11111111111111111111)]
        [TestCase(-12.11111111111111111111, -111111111111.11111111)]
        [TestCase(-2.555555555, 2244)]
        [TestCase(2244, 0)]
        public void Multiply(double a, double b)
        {
            double x = a, y = b;
            MyCalculator my = new MyCalculator();
            Assert.AreEqual(x * y, my.multiply(x, y));
        }

        [TestCase(-0, -0)]
        [TestCase(0, 0)]
        [TestCase(11111111111111111111, 11111111111111111111)]
        [TestCase(-12.11111111111111111111, -111111111111.11111111)]
        [TestCase(-2.555555555, 2244)]
        [TestCase(2244,0)]
        public void Divide(double a, double b)
        {
            double x = a, y = b;
            MyCalculator my = new MyCalculator();
            Assert.AreEqual(x / y, my.division(x, y));
        }


    }
}
