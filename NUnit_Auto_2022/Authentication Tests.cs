using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace NUnit_Auto_2022
{
    class AuthenticationTests
    {

        IWebDriver driver;

        const string protocol = "http";
        const string hostname = "86.121.249.150";
        const string port = "4999";
        const string path = "/#/";

        string url = protocol + "://" + hostname + ":" + port + path;

        [SetUp]
        public void Setup()
        {
            //driver = new ChromeDriver();

            //Chrome
            var options = new ChromeOptions();
            //options.AddArgument("--start-maximized"); //va porni browserul direct maximizat
            //options.AddArgument("headless");
            options.AddArgument("ignor-certificate-errors");
            var proxy = new Proxy();
            proxy.HttpProxy = "127.0.0.1:8080";
            proxy.IsAutoDetect = false;
            //options.Proxy = proxy;
            //options.AddExtension("C:\\Users\\Aaron\\Downloads\\Unconfirmed 695347.crdownload"); // deschide chrome cu extensia indicata

            //Firefox
            //e indicat sa folosesti metoda cu liste (ex:firefox) statice
            var firefoxOptions = new FirefoxOptions();
            string[] optionList =
            {
                //"--headles",
                "--ignor-certificate-errors",
                "--no-sandbox",
                "--disable-gpu"
            };
            firefoxOptions.AddArguments(optionList);
            FirefoxProfile fProfile = new FirefoxProfile();
            fProfile.AddExtension("C:\\Users\\Aaron\\Downloads\\Unconfirmed 730345.crdownload");
            firefoxOptions.Profile = fProfile;


            //Edge 
            var edgeOptions = new EdgeOptions();
            //edgeOptions.AddExtension("C:\\Users\\Aaron\\Downloads\\Unconfirmed 695347.crdownload"");
            edgeOptions.AddArguments("args", "['--start-maximized'], '--headless'");
            edgeOptions.AddArgument("headless");

            driver = new ChromeDriver(options);
            //driver = new FirefoxDriver(firefoxOptions);
            //driver = new EdgeDriver(edgeOptions);
            driver.Manage().Window.Maximize(); // face maximize din fereastra cu ajutorul butonului de maximize

        }

        [TestCase("dinosaur", "dinosaurpassword", "", "")]
        [TestCase("dinosaur", "", "", "Password is required!")]
        [TestCase("", "", "Username is required!", "Password is required!")]
        [TestCase("", "dinopass", "Username is required!", "")]
        public void Test01(string user, string pass, string userErr, string passErr)
        {
            Console.WriteLine(url);
            driver.Navigate().GoToUrl(url);

            var pageText = driver.FindElement(By.CssSelector("#root > div > div.content > div > div:nth-child(1) > div > div > h1 > small"));
            Assert.AreEqual("Home", pageText.Text);
            

            var loginLink = driver.FindElement(By.CssSelector("#root > div > div.sidebar > a:nth-child(2)"));
            loginLink.Click();
            Console.WriteLine(loginLink.GetAttribute("href"));

            pageText = driver.FindElement(By.CssSelector("#root > div > div.content > div > div:nth-child(1) > div > div > h1 > small"));
            Assert.AreEqual("Authentication", pageText.Text);

            var username = driver.FindElement(By.Id("input-login-username"));
            var password = driver.FindElement(By.Id("input-login-password"));
            var submit = driver.FindElement(By.CssSelector("#login-form > div:nth-child(3) > div.text-left.col-lg > button"));

            var usernameError = driver.FindElement(By.CssSelector("#login-form > div:nth-child(1) > div > div > div.text-left.invalid-feedback"));
            var passwordError = driver.FindElement(By.CssSelector("#login-form > div.form-group.row.row-cols-lg-true > div > div > div.text-left.invalid-feedback"));


            username.Clear();
            username.SendKeys(user);

            password.Clear();
            password.SendKeys(pass);

            submit.Submit();

            Assert.AreEqual(userErr, usernameError.Text);
            Assert.AreEqual(passErr, passwordError.Text);


        }


        //implicity wait test  -la nivelul browserului
        [Test]
        public void Test02()//gasirea elementelor in pagina
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            string url = protocol + "://" + hostname + ":8081/lazy.html";
            driver.Navigate().GoToUrl(url);

            var button1 = driver.FindElement(By.Id("btn1"));
            button1.Click();
        }


        //explicit wait test - la nivelul elementului
        [Test]
        public void Teste03()
        {

            string url = protocol + "://" + hostname + ":8081/lazy.html";
            driver.Navigate().GoToUrl(url);

            //var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            //var button1 = driver.FindElement(By.Id("btn1"));
            //var button1 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("btn1")));
            
            
            var button1 = Utils.WaitForElement(driver, 20, By.Id("btn1"));
            button1.Click();
            
        }

        [Test]

        public void Test04()
        {
            string url = protocol + "://" + hostname + ":8081/lazy.html";
            driver.Navigate().GoToUrl(url);

            var button2 = Utils.WaitForElement(driver, 15, By.Id("btn2"));
            for (int i = 0; i < 100; i++)
            {
                button2.Click();
            }
            Thread.Sleep(2000);//pausing test execution for 20 sec !! please avoid!!1
        }


        [Test]
        public void Test05()
        {
            string url = protocol + "://" + hostname + ":8081/lazy.html";
            driver.Navigate().GoToUrl(url);

            /*  DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
              fluentWait.Timeout = TimeSpan.FromSeconds(20);
              fluentWait.PollingInterval = TimeSpan.FromMilliseconds(100);
              fluentWait.Message = "Sorry !! The element in the page cannot be found!";
              fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
              var element = fluentWait.Until(x => x.FindElement(By.Id("btn2")));
              element.Click();*/

            var element = Utils.WaitForFluentElement(driver, 20, By.Id("btn2"));
            element.Click();


        }

        [Test]
        public void Test06()
        {
            driver.Navigate().GoToUrl("https://magazinulcolectionarului.ro/");

            var cookies = driver.Manage().Cookies;
            Console.WriteLine("The site contains {0} cookies", cookies.AllCookies.Count);
            Utils.PrintCookies(cookies);
           
            Cookie myCookie = new Cookie("myCookie", "blablabla");
            cookies.AddCookie(myCookie);
            Utils.PrintCookies(cookies);

            var ck = cookies.GetCookieNamed("PHPSESSID");
            Console.WriteLine("Cookie name {0} and value {1}", ck.Name, ck.Value);


            
            cookies.DeleteAllCookies();
            Console.WriteLine("The site contins {0} cookies", cookies.AllCookies.Count);

            Utils.TakeScreenshotWithDate(driver, "C:\\Stefania\\screenShot", "screenshot", ScreenshotImageFormat.Png);

        }

        [Test]
        public void Test07()//alerta
        {
            driver.Navigate().GoToUrl("http://86.121.249.150:4999/#/alert");
            var alertButton = driver.FindElement(By.Id("alert-trigger"));
            var confirmButton = driver.FindElement(By.Id("confirm-trigger"));
            var promptButton = driver.FindElement(By.Id("prompt-trigger"));

            alertButton.Click();
            IAlert alert = driver.SwitchTo().Alert();
            Console.WriteLine(alert.Text);
            alert.Accept();

            confirmButton.Click();
            alert = driver.SwitchTo().Alert();
            Console.WriteLine(alert.Text);
            alert.Dismiss();

            promptButton.Click(); // doar aici se poate pune sendkeys
            alert = driver.SwitchTo().Alert();
            Console.WriteLine(alert.Text);
            alert.SendKeys("alex");
            alert.Accept();
        }

        [Test]
        public void Test08()//hoverul expandeaza elemente in pagina,  
        {
            driver.Navigate().GoToUrl(url + "hover");

            //Metoda1
            //var hoverButton = driver.FindElement(By.CssSelector("#root > div > div.content > div > div.container-table.text-center.container > div > button"));
            //Actions actions = new Actions(driver);
            //action = action.MoveToElement(hoverButton);
            //IAction action = action.Build();
            //action.Perform();
            //Thread.Sleep(1000);//nu e indicat a se folosi in cod, il folosim doar daca vrem sa facem un delay pentrua  vedea testul

            //Metoda2
            var hoverButton = driver.FindElement(By.ClassName("btn-outline-info"));

            Actions actions = new Actions(driver);
            actions.MoveToElement(hoverButton).Build().Perform();//muta mouseul pe buton, actions nbuild perform-- se foloseste si pentru butoanele cu drag and drop

            var catSelect = driver.FindElement(By.Id("Cat"));//selectan butonul cat dupa id
            catSelect.Click();//apasa click pen butonul cat

            var resultText = driver.FindElement(By.Id("result")).Text;//identifica mesajul dupa apasarea butonului

            Assert.AreEqual("You last clicked the Cat", resultText);

            var allItems = driver.FindElements(By.ClassName("clickable"));//pentru toate elementele din butonul hover
            foreach (var item in allItems)
            {
                item.Click();
                var text = item.Text;
                var resultTxt = driver.FindElement(By.Id("resuly")).Text;
                Assert.AreEqual(String.Format("You last clicked the {0}", text), resultTxt);
                //Thread.Sleep(2000);//nu e indicat a se folosi in cod, il folosim doar daca vrem sa facem un delay pentrua  vedea testul
            }

        }

        [Test]
        public void Test09()//stale elements (stale button)
        {
            driver.Navigate().GoToUrl(url + "stale");


            //theating a stale element: find the element before every interaction !!
            for (int i = 0; i<=100; i++)
            {
                var button = driver.FindElement(By.Id("stale-button"));
                button.Click();
            }

            //javaScriptExecutar este ultima metoda pe care o folosim , orice avem cu drive. ... se paote executa si cu java
            Utils.ExecuteJsScript(driver, "return document.title");
            Utils.ExecuteJsScript(driver, "alert('enter correct login credentials to continue ');");
        }

        //javaScriptExecutar este ultima metoda pe care o folosim 

        [Test]
        public void Test10()//shimbarea ferestrei
        {
            driver.Navigate().GoToUrl(url); // merge pe pagina principala

            //Creare de taburi noi(ctrl+t)
            /*var body = driver.FindElement(By.TagName("body"));
            body.SendKeys(Keys.Control);
            body.SendKeys("t");*/

            foreach (var handle in driver.WindowHandles)  //read only colections de tip string
            {
                driver.SwitchTo().Window(handle);
                Console.WriteLine(handle);
            }
        }

        [Test]
        public void Test11()//switching frames , se foloseste in pagina de contact unde avem harta cu sediul firmei (iframe)
        {
            driver.Navigate().GoToUrl("https://www.vexio.ro/info/despre-noi/contact/");

            var iframe = driver.FindElement(By.TagName("iframe"));

            driver.SwitchTo().Frame(iframe);//este pagina in pagina, prin switchto te duce la pagina din pagina
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }


    }
}
