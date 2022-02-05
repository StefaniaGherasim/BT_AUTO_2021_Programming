using NUnit.Framework;
using NUnit_Auto_2022.PageModels.POM;
using NUnit_Auto_2022.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.Tests
{
    class AuthTest 
    {
        IWebDriver driver;

        string url = FrameworkConstants.GetUrl();

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        

        [Test]
        public void BasicAuth()
        {
           // driver.Navigate().GoToUrl("http://86.121.249.150:4999/#/login");//navigam pe pagina
            driver.Navigate().GoToUrl(url + "login");//navigam pe pagina
            LoginPage lp = new LoginPage(driver);//gasim elementele in pagina
            Assert.AreEqual("Authentication", lp.CheckPage());
            lp.Login("user1", "pass1");//user1 si pass1 sunt valorile care se dau pentru verificare
        } 


        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }



    }
}
