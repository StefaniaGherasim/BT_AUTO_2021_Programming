﻿ using System;

namespace BT_AUTO_2021_Programming
{
    class Program
    {
        static void Main(string[] args)
        {

            const int MAX_SIZE = 100;
            const double PI = 3.141592;
            const int MAX_NUMBER = 5;

            Console.WriteLine("Hello World!");
            Console.WriteLine("Ana are mere.");
            Console.WriteLine(6 + 2);
            Console.WriteLine("6+2");

            int numberOfStudets = 5;
            int count;
            int a, b;
            a = numberOfStudets + 1;
            a = a + numberOfStudets;
            short s = 5;
            ulong ul = 65;

            float numberFloat = 5.6F;
            double numberDouble = 5.6;

            float f = (float)numberDouble;
            int numberInt = (int)f;
            long l = numberOfStudets;

            Console.WriteLine(typeof(int).IsPrimitive);

            bool myBoolean = false;
            char ch = (char)100; // '1' != 1

            string myString = "Ana are mere si pere";
            string result = myString + "si struguri";
            Console.WriteLine(result);

            DateTime dataCurenta = new DateTime(2021, 12, 8);
            Console.WriteLine(dataCurenta);

            Console.WriteLine(numberDouble * a);
            Console.WriteLine(numberFloat * a);

            Console.WriteLine(numberFloat / a);
            Console.WriteLine(numberDouble / a);
            Console.WriteLine(5 / 6);
            Console.WriteLine(5 / 6F);
            Console.WriteLine(5 / 6.0);

            Console.WriteLine(5 % 6);

            int x = 2;
            x += 5; // x = x + 5;
            //x++ >=< x = x + 1;
            //++x >=< x = x + 1;
            Console.WriteLine(x++);// a afisa si apoi a incrementat
            Console.WriteLine(++x);// a incrementat cu o unitate si apoi a afisat

            //Console.WriteLine((x == a));// rezulattul este un boolean
           // Console.WriteLine((x > a));
           // Console.WriteLine((x < a));
           // Console.WriteLine(!(x != a));
           // Console.WriteLine((x < a) || (x == a));//se folosesc la conditii (if)

            int number =  4;
            Console.WriteLine("Number tested is" + number);

            if (number >= 0)
            {   
                Console.WriteLine("Number is positive");
            }
            else
            {
                Console.WriteLine("Number is negativ");
            }

            if (number % 2 == 0)
            {
                Console.WriteLine("Even number!");
            }
            else
            {
                Console.WriteLine("Old number!");
            }

            if (number <=40 && number >=0)
            {
                if (number <= 20)
                {
                    Console.WriteLine("Student failes");
                }
                else
                {
                    Console.WriteLine("Student passed");
                }
            }
            else
            {
                Console.WriteLine("Number is invalid!");
            }

            //oneline if/else
            String message = (number % 2 == 0) ? "Even" : "Old";
            Console.WriteLine(message);
          
            if (number ==1)
            {
                Console.WriteLine("Monday");
            }
            if (number ==2)
            {
                Console.WriteLine("Tuesday");
            }
            if (number == 3)
            {
                Console.WriteLine("Wednesday");
            }
            if (number == 4)
            {
                Console.WriteLine("Thursday");
            }
            if (number == 5)
            {
                Console.WriteLine("Friday");
            }
            if (number == 6 )
            {
                Console.WriteLine("Saturday");
            }
            if (number == 7)
            {
                Console.WriteLine("Sunday");
            }
            if (number <1 || number>7)
            {
                Console.WriteLine("Sorry not a valid day!");
            }

            switch(number)//switch functioneaza doar pentru valori punctuale
            {
                case 1:
                    {
                        Console.WriteLine("Monday");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Tuesday");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Wednesday");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Thursday");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Friday");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Saturday");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Sunday");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Not a valid day!");
                        break;
                    }
            }

            int counter = 0;
            while (counter <= MAX_NUMBER)
            {
                Console.WriteLine("Current number is: " + counter);
                counter++;
            }

            counter = 0;
            do
            {
                Console.WriteLine("Current number is: " + counter);
                counter++;
            }
            while (counter <= MAX_NUMBER);


        }
    }
}   

