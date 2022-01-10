using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    public class PartTimeEmplyee : Emplyee
    {
        public PartTimeEmplyee(string firstName, string lasttName, string adress, string city, string country, double salary) : base(firstName, lasttName, adress, city, country, salary)
        {
        }
    }
}