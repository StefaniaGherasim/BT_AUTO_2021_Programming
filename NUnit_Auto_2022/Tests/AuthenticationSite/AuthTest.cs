using NUnit.Framework;
using NUnit_Auto_2022.PageModels.POM;
using NUnit_Auto_2022.PageModels.PageFactory;
using NUnit_Auto_2022.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.Tests
{
    class AuthTest : BaseTest
    {
        string url = FrameworkConstants.GetUrl();

        // test authentication with page object model (pom)
        [Test]
        public void BasicAuth()//contine instantieri de pagini, apleluri catre paginile respective si aserturi 
        {
            // driver.Navigate().GoToUrl("http://86.121.249.150:4999/#/login");//navigam pe pagina
            driver.Navigate().GoToUrl(url + "login");//navigam pe pagina
            //LoginPage lp = new LoginPage(driver);//gasim elementele in pagina - se foloseste cand avem doar un tip de framework (ex POM)
            PageModels.POM.LoginPage lp = new PageModels.POM.LoginPage(driver);//am folosit PageModels.POM. ...deoarece avem doua pagini cu acelasi nume dar in diferite clase (aceasta e POM-page object model) 
            Assert.AreEqual("Authentication", lp.CheckPage());// verifica daca suntem pe pagina care trebuie 
            lp.Login("user1", "pass1");//user1 si pass1 sunt valorile care se dau pentru verificare
        }


        //test authentication with page factory
        [Test]
        public void BasicAuthPf()
        {
            driver.Navigate().GoToUrl(url + "login");
            PageModels.PageFactory.LoginPage lp = new PageModels.PageFactory.LoginPage(driver);
            Assert.AreEqual("Authentication", lp.CheckPage());
            lp.Login("user1", "pass1");

        }//testele pt pom si pentru page factory sunt la fel 

    }
}
