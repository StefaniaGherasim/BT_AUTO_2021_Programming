using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.utilities
{
    public class Browser // methoda statica  Browser static   -ocupa mai putin memorie, e accesat mai repede, va fi shared ca info intre toate testele, 
    {

        public static IWebDriver GetDriver(webBrowsers browserType)
        {
            switch (browserType)
            {
                case webBrowsers.Chrome:
                    {


                        return new ChromeDriver();
                    }
                case webBrowsers.Firefox:
                    {
                        var firefoxOptions = new FirefoxOptions();
                        List<string> optionList = new List<string>();
                        /*string[] optionList =
                        {
                            //"--headles",
                            "--ignor-certificate-errors",
                            "--no-sandbox",
                             "--disable-gpu"
                        };*/
                        if (FrameworksConstants.startHeadless)
                        {
                            optionList.Add("--headless");
                        }
                        if (FrameworkConstants.)
                        firefoxOptions.AddArguments(optionList);
                        FirefoxProfile fProfile = new FirefoxProfile();
                        fProfile.AddExtension("C:\\Users\\Aaron\\Downloads\\Unconfirmed 730345.crdownload");
                        firefoxOptions.Profile = fProfile;

                        return new FirefoxDriver();
                    }
                case webBrowsers.Edge:
                    {
                        return new EdgeDriver();
                    }
                default:
                    {
                        throw new BrowserTypeException();
                    }

            }
        }
    }

    public enum webBrowsers //lista de valori
    {
        Chrome,
        Firefox,
        Edge
    }

}
