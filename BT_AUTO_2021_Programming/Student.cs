using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    class Student : Person
    {
        string currentStudyYear;
        bool hasScholarschip;
        bool hasDormRoom;
        string[] courses;

        public Student(string currentStudyYear, bool hasScholarschip, bool hasDormRoom, string name, char sex)
        {
            this.currentStudyYear = currentStudyYear;
            this.hasScholarschip = hasScholarschip;
            this.hasScholarschip = hasDormRoom;
            this.SetName(name);
            this.SetSex(sex);
        }
        public Student()
        {

        }

        public void PrintStudent()
        {
            base.PrintPerson();
            Console.WriteLine("Current study year is {0}", currentStudyYear);
            Console.WriteLine("Dormroom status: {0}", hasDormRoom);
            Console.WriteLine("Scholarship status: {0}", hasScholarschip);
        }

       /* public void EnrollCourse(string course)
        {
            this.courses.SetValue(course, 0);
        }*/
    }
}
