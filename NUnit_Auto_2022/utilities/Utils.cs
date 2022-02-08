using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace NUnit_Auto_2022
{
    public class Utils
    {

        public static IWebElement WaitForElement(IWebDriver driver, int seconds, By locator)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
        }

        public static IWebElement WaitForFluentElement(IWebDriver driver, int seconds, By locator)
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver)
            {
                Timeout = TimeSpan.FromSeconds(seconds),
                PollingInterval = TimeSpan.FromMilliseconds(100),
                Message = "Sorry !! The element in the page cannot be found!"
            };
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            return fluentWait.Until(x => x.FindElement(locator));
        }

        public static void PrintCookies(ICookieJar cookies)
        {
            foreach (Cookie c in cookies.AllCookies)
            {
                Console.WriteLine("Cooke name {0} - cookie value {1}", c.Name, c.Value);
            }
        }

        /// <summary>
        /// the method creates a screenshot and saves it into a folder choose by tester
        /// </summary>
        /// <param name="driver">the web driver instance browser from witch the screen shot will be taken</param>
        /// <param name="path">the path were the screen shot will be saved</param>
        /// <param name="fileName">the base file name that will have appended the data to have unique</param>
        /// <param name="format">specify </param>
        public static void TakeScreenshotWithDate(IWebDriver driver, string path, string fileName, ScreenshotImageFormat format)
        {
            DirectoryInfo validation = new DirectoryInfo(path);
            if (!validation.Exists)
            {
                validation.Create();
            }
            string currentDate = DateTime.Now.ToString();
            StringBuilder sb = new StringBuilder(currentDate);
            sb.Replace(":", "_");
            sb.Replace(".", "_");
            sb.Replace(" ", "_");
            string finalFilePath = String.Format("{0}\\{1}_{2}.{3}", path, fileName, sb.ToString(), format);
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(finalFilePath, format);
        }

        public static void ExecuteJsScript(IWebDriver driver, string script)//pasezi browserului un script de java scrept sa il execute
        {
            var jsExecutor = (IJavaScriptExecutor)driver;//executorul
            var result = jsExecutor.ExecuteScript(script);//returneaza un obiect
            if (result != null)
            {
                Console.WriteLine(result.ToString());//arata ce s'a executat
            }
        }

        /// <summary>
        /// Converts a config file that has lines like key=value into a Dictionary with key and value
        /// </summary>
        /// <param name="configFilePath"> The path of the config file</param>
        /// <returns>A dictionary with a key value pair of type string and string representing the lines in the config file</returns>
        public static Dictionary<string, string> ReadConfig(string configFilePath)
        {
            var configData = new Dictionary<string, string>();
            foreach (var line in File.ReadAllLines(configFilePath))
            {
                string[] values = line.Split('=');
                configData.Add(values[0].Trim(), values[1].Trim());
            }
            return configData;
        }

        public static string [][] GetGenercData(string path)
        {
            var lines = File.ReadAllLines(path).Select(a => a.Split(',')).Skip(1);
            return lines.ToArray();
        }
    }
}
