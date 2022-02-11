using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace NUnit_Auto_2022.DataModels
{
    [XmlRoot (ElementName = "credentials")]
    public class Credentials
    {
        [XmlElement(ElementName = "username")]
        public string Username { get; set; }

        [XmlElement(ElementName = "password")]
        public string Password { get; set; }
    }
}
