using NUnit_Auto_2022.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.utilities//factory model
{
    public class Browser // methoda statica  Browser static   -ocupa mai putin memorie, e accesat mai repede, va fi shared ca info intre toate testele, 
    {

        public static IWebDriver GetDriver(webBrowsers browserType)//ca sa nu instantiem de fiecaredata un obiect browser, browserul sa fie static
        {
            switch (browserType)
            {
                //instantiaza Chrome driver 
                case webBrowsers.Chrome:
                    {
                        var options = new ChromeOptions();
                        //optiuni entru driver in functie de FrameworkConstants
                        if (FrameworkConstants.startMaximized)
                        {
                            options.AddArgument("--start-maximized"); //va porni browserul direct maximizat
                        }
                        if (FrameworkConstants.startHeadless)
                        {
                            options.AddArgument("headless");//browserul va pornii headless
                        }
                        if (FrameworkConstants.ignotCertErr)
                        {
                            options.AddArgument("ignor-certificate-errors");
                        }
                        //proxy def.
                        var proxy = new Proxy
                        {
                            HttpProxy = FrameworkConstants.browserProxy,
                            IsAutoDetect = false
                        };
                        if (FrameworkConstants.useProxy)
                        {
                            options.Proxy = proxy;
                        }
                        //initialiate Chrome driver with options
                        return new ChromeDriver(options);
                    }
                //instantiaza Firefox driver 
                case webBrowsers.Firefox:
                    {
                        //definire optiuni firefox bazate pe FrameworkConstants
                        var firefoxOptions = new FirefoxOptions();
                        List<string> optionList = new List<string>();
                     

                        if (FrameworkConstants.startHeadless)
                        {
                            optionList.Add("--headless");
                        }
                        if (FrameworkConstants.ignotCertErr)
                        {
                            optionList.Add("--ignor-certificate-errors");
                        }
                        firefoxOptions.AddArguments(optionList);
                        FirefoxProfile fProfile = new FirefoxProfile();
                        if (FrameworkConstants.startWithExtension)
                        {
                            fProfile.AddExtension(FrameworkConstants.GetExtensionName(browserType));

                        }
                        firefoxOptions.Profile = fProfile;
                        return new FirefoxDriver(firefoxOptions);
                    }
                //instantiaza Edge driver 
                case webBrowsers.Edge:
                    {
                        var edgeOptions = new EdgeOptions();
                        if (FrameworkConstants.startMaximized)
                        {
                            edgeOptions.AddArguments("['--start-maximized']");
                        }
                        if (FrameworkConstants.startHeadless)
                        {
                            edgeOptions.AddArguments("headless");
                        } 
                        if (FrameworkConstants.startWithExtension)
                        {
                            edgeOptions.AddExtension(FrameworkConstants.GetExtensionName(browserType));
                        }
                        return new EdgeDriver(edgeOptions);
                    }
                default:
                    {//driverul specificat nu este implementat (diferit de cele secificate mai sus)
                        throw new BrowserTypeException(browserType.ToString());
                    }

            }
        }
    }

    public enum webBrowsers //lista de valori -- se poate face si intr'un fisier separat 
    {
        Chrome,
        Firefox,
        Edge
    }

}
