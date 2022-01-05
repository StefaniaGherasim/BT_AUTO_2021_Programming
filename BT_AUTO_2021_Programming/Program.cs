 using System;
using System.Collections.Generic;

namespace BT_AUTO_2021_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            //Course01(args);
            //Course02(args);
            //Course03(args);
            //Course04();
            // Course05();

            Course07();
        }

        static void Course01(string[] args)
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

            int number = 4;
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

            if (number <= 40 && number >= 0)
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

            if (number == 1)
            {
                Console.WriteLine("Monday");
            }
            if (number == 2)
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
            if (number == 6)
            {
                Console.WriteLine("Saturday");
            }
            if (number == 7)
            {
                Console.WriteLine("Sunday");
            }
            if (number < 1 || number > 7)
            {
                Console.WriteLine("Sorry not a valid day!");
            }

            switch (number)//switch functioneaza doar pentru valori punctuale
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

            for (counter = 0; counter <= MAX_NUMBER; counter++)
            {
                Console.WriteLine("Current number is :" + counter);
                Console.WriteLine("Current number is :{0}", counter);
            }

            foreach (string argument in args)//se foloseste la parcurgerea de liste de valori
            {
                Console.WriteLine("The argument is: {0}", argument);
            }
            //se mai poate scrie cu for (ex mai jos)

            /* for(counter=0; counter < args.Length; counter++)
             {
                 Console.WriteLine("The argument is: {0}", argument);
             }*/

            foreach (string yr in args)
            {
                int febDays = 28;
                int year = int.Parse(yr);


                /* if(year %4 == 0)
                 {
                     if (year % 100 == 0 && year % 400 != 0)
                     {
                         febDays = 29;
                     }
                     if (year % 100 != 0)
                     {
                         febDays = 29;
                     }
                 }*/
                // formaula simplificata
                if (year < 1900 || year > 2016)
                {
                    Console.WriteLine("Year is out of valid bounds (1900-206)");
                }
                else
                {
                    if ((year % 4 == 0 && year % 100 == 0 && year % 400 != 0) || (year % 4 == 0 && year % 100 != 0))
                    {
                        febDays = 29;

                    }
                    Console.WriteLine("Febriary has {0} days for year {1}", febDays, year);
                }
            }
        }

        static void Course02(string[] args)
        {
            Circle c1 = new Circle();//circle este o clasa c1 este un obiec (creat din clada cu cuvantul cheie new),
            Circle c2;//c2 will be null
            c1.SetRadius(10);
            /* double area = c1.GetArea();*/
            /* Console.WriteLine(c1.GetArea());*/
            c1.PrintCircle();
            Circle c3 = new Circle();
            c3.SetRadius(5);
            /* Console.WriteLine(c3.GetArea());*/
            c3.PrintCircle();
            foreach (string p in args)
            {
                Circle c = new Circle();
                c.SetRadius(Double.Parse(p));

                Square s = new Square();
                s.SetSide(Double.Parse(p));

                Rectangle r = new Rectangle();
                r.SetSize(Double.Parse(p), Double.Parse(p));

                c.PrintCircle();
                s.PrintSquare();
                r.PrintRectangle();

            }

            Person p1 = new Person();
            p1.SetName("Stefi");
            p1.SetSex('f');
            p1.Eat();
            p1.Run();
            p1.Eat();
            p1.PrintPerson();



            Rectangle r1 = new Rectangle();
            r1.SetSize(2, 3);
            r1.PrintRectangle();


        }

        static void Course03(string[] args)
        {
            //ComputeConversion(args);
            CurrencyCalculator(156, "USD", 4.3734);
            Shape s = GetShape(12, 34, 12.4, 'a', "17d");
            //Console.WriteLine(ConcatenateStrings(args));
            Random rnd = new Random();
            GuessNumber(rnd.Next(1, 1000));
        }

        static void Course04()
        {
            DrawFullShape(5, 3);
            Console.WriteLine();
            DrawFullShape2(5, 3);
            Console.WriteLine();
            DrawShapeOutline(14, 22);
            Console.WriteLine();
            DrawShapeOutline2(14, 22);
            Console.WriteLine();
            DrawShapeCorners(10, 13);
            Console.WriteLine();
            DrawShapeCorners2(10, 13);
            Console.WriteLine();

            Circle c1 = new Circle();// instantiate c1 with default (no params) constructor
            Circle c2 = new Circle(10);//instantiate c2 with constructor having 1 double parameter
            c1.PrintCircle();
            c2.PrintCircle();

            Person p1 = new Person();
            Person p2 = new Person("Stefi", 'f', new string[] { "Romana" }, false, new DateTime());
            p1.PrintPerson();
            p2.PrintPerson();

            Rectangle r1 = new Rectangle(2, 7);
            r1.PrintRectangle();

            Square s1 = new Square(6);
            s1.PrintSquare();

            StructExample se = new StructExample();
            StructExample.MyStruct myStruct = new StructExample.MyStruct();
            myStruct.Assign(10, "abc");
            Console.WriteLine(myStruct.ComputeSum());

            StructExample.Rectangle3d r2 = new StructExample.Rectangle3d();
            r2.Assign(2, 5, 7);
            Console.WriteLine(r2.GetVolume());

        }

        static void Course05()
        {
            DrawShapeOutline(5);
            DrawShapeOutline(20,5);
            DrawShapeCorners(6);
            DrawFullShape(7);

            Circle c = new Circle(4);
            Object o = new Object();
            c.Draw();
            Triangle t1 = new Triangle(5, 7, 9);
            t1.Draw();
            Square s1 = new Square(5);
            Rectangle r1 = new Rectangle(2, 7);
            Console.WriteLine(s1.GetArea());
            Console.WriteLine(r1.GetArea());

            Console.WriteLine(c.ToString());
            Console.WriteLine(t1.ToString());
            Console.WriteLine(r1.ToString());
            Console.WriteLine(s1.ToString());

            Teacher teacher1 = new Teacher("Programing", "UPB", 2000, "Gigel Programatoru", 'm');
            teacher1.PrintTeacher();

            Student student1 = new Student("an1", true, true, "Andreea A", 'f');
            student1.PrintStudent();
        }

        private static void Course07()
        {
            Square s1 = new Square();
            Rectangle r1 = new Rectangle();
            Shape sh1 = new Shape();

            //polymorphism
            IShape s2 = new Square();
            IShape r2 = new Rectangle();
            IShape sh2 = new Shape();// nu exista  IShape sh = new IShape()


            List<string> lista= new List<string>();
            List<IShape> shapeList = new List<IShape>();
            shapeList.Add(s2);
            shapeList.Add(r2);
            shapeList.Add(sh2);
            shapeList.Add(s1);

            s1.Draw();
            s2.Draw();
            s2.State();
            ((AbstractShape)s2).DoSomthing();

            s1.PrintSquare();
            ((Square)s2).PrintSquare();

            //example of using polimorphism
            Shape sh3;
            string type = "rectangle";

            switch (type)
            {
                case "square":
                    {
                        sh3 = new Square();
                        break;
                    }
                case "rectangle":
                    {
                        sh3 = new Rectangle();
                        break;
                    }
                default:
                    {
                        sh3 = new Shape();
                        break;
                    }
            }
            sh3.Draw();
            sh3.Erase();
            IIntf ob1 = new MyParticularShape();
            IClass ob2 = new MyParticularShape();
            ob1.Print();
            ob2.Print();

            PartialClass pc = new PartialClass();
            pc.Method1();
            pc.Method2();


            /* //without polymorpfism  --  DO NOT DO THIS!!!

             Square s3 = new Square();
             Rectangle r3 = new Rectangle();
             Shape sh4 = new Shape();

             switch (type)
             {
                 case "square":
                     {
                         s3.Draw();
                         break
                     }
                 case "rectangle":
                     {
                         r3.Draw();
                         break;
                     }
                 default:
                     {
                         sh4.Draw();
                         break;
                     }
             }*/

        }
         
        public static void DrawFullShape(int width, int height)
        {
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i< width; i++)//this will print a single line with * counting width
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
         }

        public static void DrawFullShape(int l)
        {
            DrawFullShape(l,l);
        }

        public static void DrawFullShape2(int width, int height)
        {
            String s = "";
            for (int i = 0; i < width; i++)//this will print a single line with * counting width
            {
                s += "*";
            }

            for (int j = 0; j < height; j++)
            {
                
                Console.WriteLine(s);
            }
        }

        public static void DrawShapeOutline(int width, int height)
        {
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    if (j == 0 || j == height - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        if (i == 0 || i == width - 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                 
                }
                Console.WriteLine();
            }
        }
         
        public static void DrawShapeOutline(int l)
        {
             DrawShapeOutline(l,l);
        }

        public static void DrawShapeOutline2(int width, int height)
        {
            String s = "";
            String s1 = "";

            for (int i = 0; i < width; i++)//this will print a single line with * counting width
            {
                s += "*";
                if (i == 0 || i == width - 1)
                {
                    s1 += "*";
                }
                else
                {
                    s1 += " ";
                }
            }

            for (int j = 0; j < height; j++)
            {
                if (j == 0 || j == height - 1)
                {
                    Console.WriteLine(s);
                }
                else
                {
                    Console.WriteLine(s1);
                }

            }
        }

        public static void DrawShapeCorners(int width, int height)
        {
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)//this will print a single line with * counting width
                {
                    // if ((j==0 && i==0) || (j==0 && i== width-1) || (j== height-1 && i ==0) || (j==height-1 && i==width-1))
                    if (j == 0 || j == height - 1)
                    {
                        if (i == 0 || i == width - 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }

                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void DrawShapeCorners(int l)
        {
            DrawShapeCorners(l,l);
        }

        public static void DrawShapeCorners2(int width, int height)
        {
            String s = "";
            String s1 = "";

            for (int i = 0; i < width; i++)//this will print a single line with * counting width
            {
                s += " ";
                if (i == 0 || i == width - 1)
                {
                    s1 += "*";
                }
                else
                {
                    s1 += " ";
                }
            }

            for (int j = 0; j < height; j++)
            {
                if (j == 0 || j == height - 1)
                {
                    Console.WriteLine(s1);
                }
                else
                {
                    Console.WriteLine(s);
                }

            }
        }

        static bool IsOddNumber(int number)
        {
             return number % 2 != 0;
        }

        static int TestValue(int testval, int target)
        { 
            if (testval < target)
            {
                Console.WriteLine("Number to be guess is higher!");
                return -1;
            }
            if (testval > target)
            {
                Console.WriteLine("Number to be guess is lower!");
                return 1;
            }
            return 0;
        }

        static void GuessNumber (int n)
        { int currentNumber = 0;
            do
            {
                currentNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Number chosen is {0}", currentNumber);
            }
            while (TestValue(currentNumber, n) != 0);
        }

        static Shape GetShape(int x, int y, double a, char t, string s)
        {
            Console.WriteLine(x);
            return new Shape();
        }

        static string ConcatenateStrings(string[] args)
        {
            string returnString = "";

            foreach (string s in args)
            {
                returnString += s; // returnString = returnString + s;
            }
            return returnString;
        }

        static public void ComputeConversion(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("The aplication receives only 3 parameters: amount, currency, exchange rate");
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", args[0], args[1], args[2]);
                CurrencyCalculator(Double.Parse(args[0]), args[1], Double.Parse(args[2]));
            }
        }

        static void CurrencyCalculator(double amount, string currency, double conversionRate)//semnatura functiei
        {
            Console.WriteLine("By converting {0} {1} into RON we obtain {2} RON", amount, currency, amount * conversionRate);
        }
    }

}   

