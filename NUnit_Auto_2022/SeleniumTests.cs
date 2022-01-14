using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022
{
    class SeleniumTests 
    {
        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            // driver = new ChromeDriver();
            //driver = new FirefoxDriver();
            driver = new EdgeDriver();
        }

        [Test]
        public void Test1()
        {            
            driver.Url = "https://google.com";
            driver.Navigate();            
        }

        [Test]
        public void Test2()
        {
            driver.Url = "https://google.com";
            driver.Navigate();
        }

        [TearDown]
        public void TearDown()
        {
            //driver.Close();
            driver.Quit();
        }

    }
}
