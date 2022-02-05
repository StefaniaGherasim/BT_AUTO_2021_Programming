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

       /* public const bool startHeadless = false;
        public const bool useProxy = false;
        public const bool startMaximized = false;
        public const bool ignotCertErr = true;
        public const string browserProxy = "127.0.0.1:8080";
        public const bool startWithExtension = true;
        public string  x = " ";*/

        public static string GetUrl()
        {
            return String.Format("{0}://{1}:{2}{3}", protocol, hostname, port, path);
        }

        /*public static string GetExtensionName(WebBrowsers browserType)
        {
            switch (browserType)
            {
                case WebBrowsers.Firefox:
                    {
                        return String.Format("");
                    }
            }
        }*/
    }
}
