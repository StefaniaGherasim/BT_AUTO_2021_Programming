using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    class Teacher : Person
    {
        string courseSpecialization;
        string university;
        double salary;

        public Teacher(string courseSpecialization, string university, double salary)
        {
            this.courseSpecialization = courseSpecialization;
            this.university = university;
            this.salary = salary;
        }

        public Teacher(string courseSpecialization, string university, double salary, string name, char sex)
        {
            this.courseSpecialization = courseSpecialization;
            this.university = university;
            this.salary = salary;
            this.SetSex(sex);
            this.SetName(name);
        }

        public Teacher()
        {
             
        }

        public void Teach()
        {
            Console.WriteLine("Teacher is teaching specializarion{0)", courseSpecialization);

        }

        public void PrintTeacher()
        {
            base.PrintPerson();
            Console.WriteLine("Teacher works at university {0} on specialization {1} and has salary{2}", university, courseSpecialization, salary);
        }


    }
}
