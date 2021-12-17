using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    class StructExample
    {
        struct MyStruct
        {
            int number;
            string teststring;

            public void Assign(int number, string testString)
            {
                this.number = number;
                this.teststring = teststring;
            }

            ComputeSum()
            {
                int sum = 0;
                for (int i = 0; i < number; i++)
                {
                    sum += i;
                }
                return sum;



            }
        }
        public struct Rectangle
        {
            double l;
            double L;
            double h;

            public void Assign(double l, double L, double h)
            {
                this.l = l;
                this.L = L;
                this.h = h;
            }
            public int GetVertices
            {

            }
        }
    }

}

