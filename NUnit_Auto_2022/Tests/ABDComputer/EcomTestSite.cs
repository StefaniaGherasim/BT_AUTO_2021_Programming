﻿using NUnit.Framework;
using NUnit_Auto_2022.PageModels.POM;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.Tests
{
    class EcomTestSite
    {
        IWebDriver driver;
        //https://www.abdcomputer.ro/

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.abdcomputer.ro/");
        }

        [Test]
        public void LoginTest()
        {
            LandingPage lp = new LandingPage(driver);
            Assert.AreEqual("Produse IT Renew, Refurbish, Noi & SH", lp.CheckPage());
            lp.LoginNavigate();
        }

        [Test]
        public void RegisterUnchecked()
        {
            LandingPage lp = new LandingPage(driver);
            lp.LoginNavigate();
            RegisterPage rp = new RegisterPage(driver);
            Assert.AreEqual("Sunt client nou", rp.CheckPage());//verifica daca sunt pe pagina care trebuie
            rp.AcceptCookies();
            rp.Register("aaa", "bbbb", "0752000000", "aaaaaaaa@bt.ro", "pass123");
            //rp.Register("aaa", "bbbb", "0752000000", "aaaaaaaa@bt.ro", "pass123", "");//cu parametru optional
        }

        [Test]
        public void x()
         {

            }


        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }

}
 