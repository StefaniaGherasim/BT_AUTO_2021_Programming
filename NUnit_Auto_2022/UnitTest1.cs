using NUnit.Framework;
using System;

namespace NUnit_Auto_2022
{
    [TestFixture(15, 35)] //se pune la nivelul clasei, este optional pentru testele care nu sunt parametrizate
    [TestFixture(25, 22)] //cand se foloseste cu parametrii trebuie oboligatoriu sa avem constructor
    //public class Tests
    public class OldTests
    {
        int x;
        int y;
        public OldTests(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        [OneTimeSetUp]
        public void SetupOnce()
        {
            TestContext.Out.WriteLine("This method runs only once for all tests!");
        }

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("This method run me at any test!!");//cand deschid browserul sau schimb browserul 
        }

        [Test] // decoratorul specifica faptul ca este un test
        public void Test1()
        {
            Assert.Pass();//presupune o verificare ca este sau nu conform cu asteptarile noastre 
        }

        [Test(Description = "Test 2 with 2 numbers")]
        public void Test2()
        {
            Console.WriteLine("Test2");
            Console.WriteLine("First value is {0} , secont value is {1} ", x, y);
        }

        [TestCase(69, 24, 199)]
        [TestCase(-100, -200, -333)]
        public void Test3(int a, int b, int c)
        {
            Console.WriteLine("The sum is {0}", a + b + c + x + y);
            // Assert.AreEqual(-583, a + b + c + x + y, 0, "the test failed!!");//Assert se fpolosest4 la fieare pas din aplicatie
            // Assert.That(a == b);
            // Assert.That(a, Is.AtLeast(100)); // verifica ca a e cel putin 100
        }

        [TearDown]
        public void cleanup()
        {
            Console.WriteLine("Let's do some clean up for every test!");//inchidem browserul
        }

        [OneTimeTearDown]
        public void GeneralCleanup()
        {
            TestContext.Out.WriteLine("iT'S THE FINAL  CLEANUP!!");//ULTIMA CURATARE, se executa o singura data la final
        }


    }
}