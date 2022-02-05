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
        [SetUp]
        public void Setup()
        {

            driver = Browser.GetDriver(WebBrowsers.Chrome);
            driver = Browser.GetDriver(WebBrowsers.FireFox);
            //driver = new ChromeDriver();
           // driver = new EdgeDriver();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }


    }
}
