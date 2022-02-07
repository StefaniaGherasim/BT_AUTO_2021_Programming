using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.PageModels.POM
{
    public class LandingPage : BasePage
    {
        const string authButtonSelector = "hidden-sm"; // class
        const string authPopupSelector = "nav-stacked"; // class
        const string registerAccLinkSelector = "ul > li:nth-child(2) > a"; // css
        const string myCartSelector = "cart-count-withtext"; // class
        const string myCartAreaSelector = "cart-content"; // class
        const string myCartButtonSelector = "div"; // tag name
        const string searchBoxSelector = "search-box"; // id
        const string serachButtonSelector = "btn-primary"; // class  
        const string checkPageSelector = "h1 ";//tag

        public LandingPage(IWebDriver driver) : base(driver)
        {
        }

        public string CheckPage()
        {
            return driver.FindElement(By.TagName(checkPageSelector)).Text;
        }

        //facem operatiunea de login
        public void LoginNavigate()
        {
            var authButtn = driver.FindElement(By.ClassName(authButtonSelector));
            authButtn.Click(); //se duce pe butonul de autentificare si face click pe el
            var authArea = driver.FindElement(By.ClassName(authPopupSelector));//ne duce pe lista de butoane
            var registerAccElement = authArea.FindElement(By.CssSelector(registerAccLinkSelector));//selecteaza al doilea buton
            registerAccElement.Click();//face click pe al doilea buton
            
        }
    }
}
