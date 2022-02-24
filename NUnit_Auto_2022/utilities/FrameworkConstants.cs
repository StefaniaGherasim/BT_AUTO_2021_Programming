using NUnit_Auto_2022.utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.Utilities
{
    public class FrameworkConstants
    {
       const string protocol = "http";
       const string hostname = "86.121.249.150";
       const string port = "4999";
       const string path = "/#/";
       const string extensionPath = "Other\\ExtensionFile";

       public const bool startHeadless = false;
       public const bool useProxy = false;
       public const string browserProxy = "127.0.0.1:8080";
       public const bool startMaximized = false;
       public const bool ignotCertErr = true;
       public const bool startWithExtension = false;

       public static string decryptedCon = Utils.Decrypt(Utils.JsonRead<DataModels.DBConnString>("appsettings.json").ConnectionStrings.DefaultConnection, "btauto2022");

        public static string GetUrl()
        {
            return String.Format("{0}://{1}:{2}{3}", protocol, hostname, port, path);
        }

        public static string GetExtensionName(webBrowsers browserType)
        {
            switch (browserType)
            {
                case webBrowsers.Firefox:
                    {
                        return String.Format("{0}\\Unconfirmed 730345.crdownload", extensionPath);
                    }
                default:
                    {
                        return String.Format("{0}\\Unconfirmed 695347.crdownload", extensionPath);
                    }
            }
        }

    }
}
