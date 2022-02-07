using NUnit.Framework;
using NUnit_Auto_2022.utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.Tests
{
    class BaseTest
    {
        public IWebDriver driver;
        // befor each test
        [SetUp]
        public void Setup()
        {
            //instantiate the browser using the browser factory class created in utilities
           driver = Browser.GetDriver(webBrowsers.Chrome);
           // driver = Browser.GetDriver(webBrowsers.Firefox);
           //driver = Browser.GetDriver(webBrowsers.Edge);
           // driver = new ChromeDriver();
           // driver = new EdgeDriver();
        }

        //after each test
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }


    }
}
