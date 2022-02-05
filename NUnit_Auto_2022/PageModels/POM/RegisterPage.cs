using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace NUnit_Auto_2022.PageModels.POM
{
    class RegisterPage
    {
        const string registerTextSelector = "#register > formfield > legend ";//css
        const string firstNameInputSelector = "newfirstname";//id
        const string lastNameInputSelector = "newlastname";//id
        const string phoneInputSelector = "telephone";//id
        const string emailInputSelector = "newemail";//id
        const string passInputSelector = "newpassword ";//id
        const string passRepeatInputSelector = "newpasswordType";//id
        const string newsletterSelector = "newsletter";// id
        const string agreSelector = "agree ";//id
        const string regSubmitSelector = "#register > formfield > div:nth-child(9) > div > button"; //css

        const string loginEmailSelector = "email";//id
        const string loginPassSelector = "password";//id
        const string loginButtonSelector = "#login > formfield >div:nth-child(5) > div > button";//css

        const string cookieAcceptSellector = "#cookies-consent > div > div > div:nth-child(2) > div > div.accept-cookies.col-xs-offset-4.col-xs-4.col-sm-offset-0.col-sm-3.pull-right.col-lg-2.text-right > button";//css


        IWebDriver driver;

        public RegisterPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string CheckPage()
        {
            return driver.FindElement(By.CssSelector(registerTextSelector)).Text;
        }

        public void AcceptCookies()
        {
            driver.FindElement(By.CssSelector(cookieAcceptSellector)).Click();
        }

        public void Register(string fname, string lname, string phone, string email, string pass, string confirmPass = null) // string confirmPass = null  este parametru optional
        {
            var firstNameInput = driver.FindElement(By.Id(firstNameInputSelector));
            firstNameInput.Clear();
            firstNameInput.SendKeys(fname);
            var lasttNameInput = driver.FindElement(By.Id(lastNameInputSelector));
            lasttNameInput.Clear();
            lasttNameInput.SendKeys(lname);
            var phoneInput = driver.FindElement(By.Id(phoneInputSelector));
            phoneInput.Clear();
            phoneInput.SendKeys(phone);
            var emailInput = driver.FindElement(By.Id(emailInputSelector));
            emailInput.Clear();
            emailInput.SendKeys(email);
            var passInput = driver.FindElement(By.Id(passInputSelector));
            passInput.Clear();
            passInput.SendKeys(pass);
            var passRepeatInput = driver.FindElement(By.Id(passRepeatInputSelector));
            passRepeatInput.Clear();
            passRepeatInput.SendKeys(pass);
            var newletterCheck = driver.FindElement(By.Id(newsletterSelector));
            //newletterCheck
            var buttonSubmit = driver.FindElement(By.CssSelector(regSubmitSelector));
            buttonSubmit.Submit();//atentie la tipul de butoane  submit /click  
        }

    }
}
