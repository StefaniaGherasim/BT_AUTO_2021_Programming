using NUnit_Auto_2022;
using System;
using Xunit;
using Xunit.Abstractions;

namespace Xuni_Atauto_2022
{
    public class UnitTest1 : IDisposable
     {

        private readonly ITestOutputHelper testOutputHelper;
        public UnitTest1(ITestOutputHelper testOutputHelper)
        {
            //Console.WriteLine("Setup every test");
            this.testOutputHelper = testOutputHelper;
            testOutputHelper.WriteLine("Setup method!");
        }
       /* public void SetUp() 
        {
            Console.WriteLine("Befor every test");
        }*/

        public void Dispose()
        { 
            //Console.WriteLine("TearDown!!");
            testOutputHelper.WriteLine("TearDown!!");
        }

        [Fact]// -se foloseste fara date
       // [Theory] // se foloseste cu date
        //[InlineData(50, 100, '-', -50)]

        public void Test1()//(double a, double b, char op, double res)
        {

            //Console.WriteLine();
            testOutputHelper.WriteLine("my test!");
            Calculator c = new Calculator(50, 100, '-');
            Assert.Equal(-50, c.Compute());
        }

    }
}
