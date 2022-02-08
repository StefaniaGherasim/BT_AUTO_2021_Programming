using NUnit.Framework;
using NUnit_Auto_2022.PageModels.POM;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.Tests
{
    class EcomTestSite : BaseTest
    {
        //https://www.abdcomputer.ro/

        [Test]
        public void LoginTest()
        {
            driver.Navigate().GoToUrl("https://www.abdcomputer.ro/");
            LandingPage lp = new LandingPage(driver);
            Assert.AreEqual("Produse IT Renew, Refurbish, Noi & SH", lp.CheckPage());
            lp.LoginNavigate();
        }

        [Test]
        public void RegisterUnchecked()
        {
            driver.Navigate().GoToUrl("https://www.abdcomputer.ro/");
            LandingPage lp = new LandingPage(driver);
            lp.LoginNavigate();
            RegisterPage rp = new RegisterPage(driver);
            Assert.AreEqual("Sunt client nou", rp.CheckPage());
            rp.AcceptCookies();
            rp.Register("aaaa", "bbbb", "077777770", "aaaa@aaaa.com", "Abc123$");
        }

    }

}
 