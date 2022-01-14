using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit_Auto_2022;
using System;

namespace MSTestAuto2022
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void SetUp()
        {
            Console.WriteLine("Befor every test");
        }

        [TestMethod]
        [DataRow(100, 200, '+', 300)]
        [DataRow(100, -200, '+', -100)]
        [DataRow(-100, -200, '+', -300)]
        [DataRow(100, 0, '+', 100)]
        public void TestMethod1(double a, double b, char op)
        {
            Console.WriteLine("Testing");
            Calculator c = new Calculator(100, 200, '+');
            Assert.AreEqual(300, c.Compute());
        }
        
        [TestCleanup]
        public void TearDown()
        {
            Console.WriteLine("After every test");
        }
    }
}
