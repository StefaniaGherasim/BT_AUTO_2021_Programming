using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022
{
    class AuthenticationTests
    {

        IWebDriver driver;

        const string protocol = "http";
        const string hostname = "86.121.249.150";
        const string port = "4999";
        const string path = "/#/login";

        string url = protocol + "://" + hostname + ":" + port + path;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [TestCase("dinosaur", "dinosaurpassword")]
        [TestCase("dinosaur", "")]
        [TestCase("", "")]
        [TestCase("", "dinopass")]
        public void Test01(string user, string pass)
        {
            Console.WriteLine(url);
            driver.Navigate().GoToUrl(url);

            var username = driver.FindElement(By.Id("input-login-username"));
            var password = driver.FindElement(By.Id("input-login-password"));
            var submit = driver.FindElement(By.CssSelector("#login-form > div:nth-child(3) > div.text-left.col-lg > button"));

            username.Clear();
            username.SendKeys(user);

            password.Clear();
            password.SendKeys(pass);

            submit.Submit();

        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }


    }
}
