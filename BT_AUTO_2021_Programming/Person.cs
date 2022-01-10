using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    public class Person : IPerson
    {
        string firstName;
        string lastName;
        string adress;
        string city;
        string country;
        char sex;
        string[] nationality;
        bool isHungry;
        DateTime dob;
        private double salary;

        public Person(string firstName, string lastName, string adress, string city, string country, char sex, string[] nationality, bool isHungry, DateTime dob)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.adress = adress;
            this.city = city;
            this.country = country;
            this.sex = sex;
            this.nationality = nationality;
            this.isHungry = isHungry;
            this.dob = dob;
        }

        public Person(string firstName, char sex, string[] nationality, bool isHungry, DateTime dob)
        {
            this.firstName = firstName;
            this.sex = sex;
            this.nationality = nationality;
            this.isHungry = isHungry;
            this.dob = dob;
        }

      

        public Person(string firstName, string lasttName, string adress, string city, string country, double salary)
        {
            this.firstName = firstName;
            this.lastName = lasttName;
            this.adress = adress;
            this.city = city;
            this.country = country;
            this.salary = salary;
        }
         public Person()
            {

             }

        public Person(string v1, string v2, string v3, string v4, string v5)
        {
        }

        public void Eat()
        {
            Console.WriteLine("The persone is eating.");
            isHungry = false;
        }

        public void Run ()
        {
            Console.WriteLine("The person is running for his health!");
            isHungry = true;
        }

        public void SetName(string personName)
        {
            this.firstName = personName;
        }
        public void SetSex(char sex)
        {
            this.sex = sex;
        }

        public string GetFirstName()
        {
            return this.firstName;
        }
        public string GetlastName()
        {
            return this.lastName;
        }
        public string GetCity()
        {
            return this.city;
        }
        public string GetCountry()
        {
            return this.country;
        }
        public void PrintPerson()
        {
            Console.WriteLine("Name of the persone is {0}", firstName);
            Console.WriteLine("-> Current state for hungry is {0}", isHungry);
            Console.WriteLine("-> Person sex is {0}", sex);
        }

        public static void PrintPersonStatic(Person p)
        {
            Console.WriteLine("first name is {0} and last name is {1}", p.firstName, p.lastName);
        }
    }

}
