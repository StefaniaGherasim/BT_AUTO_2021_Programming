using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    public class Person
    {
        string name;
        char sex;
        string[] nationality;
        bool isHungry;
        DateTime dob;

        public Person(string name, char sex, string[] nationality, bool isHungry, DateTime dob)
        {
            this.name = name;
            this.sex = sex;
            this.nationality = nationality;
            this.isHungry = isHungry;
            this.dob = dob;
        }

        public Person()
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
            this.name = personName;
        }
        public void SetSex(char sex)
        {
            this.sex = sex;
        }
        public void PrintPerson()
        {
            Console.WriteLine("Name of the persone is {0}", name);
            Console.WriteLine("-> Current state for hungry is {0}", isHungry);
            Console.WriteLine("Person sex is {0}", sex);
        }
    }

}
