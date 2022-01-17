using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022
{
    class CalculatorTest
    {
        [SetUp]
        public void SetUp()
        {

        }

        [TestCase(1, '+', 1, 2)]
        [TestCase(-1, '+', -1, -2)]
        [TestCase(-1, '+', 0, -1)]
        [TestCase(0, '+', 0, 0)]
        [TestCase(0, '+', -1, -1)]
        [TestCase(123.456, '+', 999.111, 1122.567)]
        [TestCase(1, '-', 1, 0)]
        [TestCase(1, '-', 0, 1)]
        [TestCase(0, '-', 1, -1)]
        [TestCase(-1, '-', -1, 0)]
        [TestCase(123.456, '-', 23.456, 100)]
        [TestCase(11, '*', 11, 121)]
        [TestCase(11, '*', 0, 0)]
        [TestCase(-11, '*', -11, 121)]
        [TestCase(-11, '*', 11, -121)]
        [TestCase(16, '/', 4, 4)]
        [TestCase(-100, '/', 2, -50)]
        [TestCase(100, '/', 3, 33.3333)]

        public void TestCompute(double a, char op, double b, double result)
        {
            Calculator c = new Calculator(a, b, op);
            Assert.AreEqual(result, c.Compute(), 0.0001d, "The sum of number is nor as expecte!");
        }

        [TestCase(100, '/', 0)]
        public void TestComputeException(double a, char op, double b)
        {
            Calculator c = new Calculator(a, b, op);
            Assert.Throws<ArgumentException>(() => c.Compute() );
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}
