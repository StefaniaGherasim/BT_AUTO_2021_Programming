using NUnit.Framework;
using NUnit_Auto_2022.PageModels.POM;
using NUnit_Auto_2022.PageModels.PageFactory;
using NUnit_Auto_2022.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace NUnit_Auto_2022.Tests
{
    class AuthTest : BaseTest
    {
        string url = FrameworkConstants.GetUrl();

        private static IEnumerable<TestCaseData> GetCredentialsData()//furnizeaza date de test
        {
            yield return new TestCaseData("user1", "pass1");
            yield return new TestCaseData("user2", "pass2");//date de test
            yield return new TestCaseData("user3", "pass3");
            yield return new TestCaseData("user4", "pass4");
        }

        private static IEnumerable<TestCaseData> GetCredentialsDataCsv()
        {
            string path = "TestData\\Credentials.csv";
            using (var reader = new StreamReader(path))
            {
                var index = 0;
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var value = line.Split(',');
                    if (index > 0)
                    {
                        yield return new TestCaseData(value[0], value[1]);
                    }
                   
                    index++;
                }
            }
        }

        private static IEnumerable<TestCaseData> GetCredentialsDataCsv2()
        {
            foreach (var values in Utils.GetGenercData("TestData\\Credentials.csv"))
            {
                yield return new TestCaseData(values);
            }
        }

        private static IEnumerable<TestCaseData> GetCredentialsDataCSV3()
        {
            var csvData = Utils.GetDataTableFromCsv("TestData\\credentials.csv");
                for(int i=0; i< csvData.Rows.Count; i++)
            {
                yield return new TestCaseData(csvData.Rows[i].ItemArray);
            }
        }

        private static IEnumerable<TestCaseData> GetCredentialsDataExcel()
        {
            var excelData = Utils.GetDataTableFromExcel("TestData\\credentials.xlsx");
            for(int i = 0; i < excelData.Rows.Count; i++)
            {
                yield return new TestCaseData(excelData.Rows[i].ItemArray);
            }
        }

        private static IEnumerable<TestCaseData> GetCredentialsDataJson()
        {
           // DataModels.Credentials credentials = Utils.JsonRead<DataModels.Credentials>("TestData\\crededntials.json");
            var credentials = Utils.JsonRead<DataModels.Credentials>("TestData\\crededntials.json");
            yield return new TestCaseData(credentials.Username, credentials.Password);
        }

        private static IEnumerable<TestCaseData> GetCredentialsDataXml()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(DataModels.Credentials));
            foreach (var file in Utils.GetAllFilesInFolderExt("TestData\\", "*.xml"))
            {
                Console.WriteLine("Testing with file:" + file);
                using (Stream reader = new FileStream("TestData\\Credentials.xml", FileMode.Open))
                {
                    var credentials = (DataModels.Credentials)serializer.Deserialize(reader);
                    yield return new TestCaseData(credentials.Username, credentials.Password);
                }
            }

        }

        // test authentication with page object model (pom)
        [Test, TestCaseSource("GetCredentialsDataXml")]
        public void BasicAuth(string username, string password)//contine instantieri de pagini, apleluri catre paginile respective si aserturi 
        {
            // driver.Navigate().GoToUrl("http://86.121.249.150:4999/#/login");//navigam pe pagina
            driver.Navigate().GoToUrl(url + "login");//navigam pe pagina
            //LoginPage lp = new LoginPage(driver);//gasim elementele in pagina - se foloseste cand avem doar un tip de framework (ex POM)
            PageModels.POM.LoginPage lp = new PageModels.POM.LoginPage(driver);//am folosit PageModels.POM. ...deoarece avem doua pagini cu acelasi nume dar in diferite clase (aceasta e POM-page object model) 
            Assert.AreEqual("Authentication", lp.CheckPage());// verifica daca suntem pe pagina care trebuie 
            lp.Login(username, password);//user1 si pass1 sunt valorile care se dau pentru verificare
        }


        private static string[] GetUsername = new string[]
        {
"user1", "user2", "user3", "user4"
        };

        private static string[] GetPassword = new string[]
       {
           "pass1", "pass2", "pass3", "pass4"
       };

        //test authentication with page factory
        [Test]
        public void BasicAuthPf([ValueSource("GetUsername")] string username, [ValueSource("GetPassword")] string password)
        {
            driver.Navigate().GoToUrl(url + "login");
            PageModels.PageFactory.LoginPage lp = new PageModels.PageFactory.LoginPage(driver);
            Assert.AreEqual("Authentication", lp.CheckPage());
            lp.Login(username, password);

        }//testele pt pom si pentru page factory sunt la fel 

    }
}
