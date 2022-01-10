using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    public class Emplyee : Person
    {
        double salary;

        public Emplyee(string firstName, string lasttName, string adress, string city, string country,double salary) : base(firstName, lasttName, adress, city, country, salary)
        {
            this.salary = salary;
        }

        public void SetSalary(double salary)
        {
            this.salary = salary;
        }

        public static void PrintPersoneStatic(Emplyee p)
        {
            //Person.PrintPersonStatic(p);
            Console.WriteLine("Employee forst name {0} last name{1} salary {2}", p.GetFirstName(), p.GetlastName(),p.salary); 

        }
    }
}
