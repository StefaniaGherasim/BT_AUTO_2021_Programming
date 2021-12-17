using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    public class StructExample
    {
        public struct MyStruct
        {
            int number;
            string teststring;

            public void Assign(int number, string testString)
            {
                this.number = number;
                this.teststring = teststring;
            }

            public int ComputeSum()
            {
                int sum = 0;
                for (int i = 0; i < number; i++)
                {
                    sum += i;
                }
                return sum;



            }
        }
        public struct Rectangle3d
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
            public int GetVertices()
            {
                return 12;
            }

            public double GetArea()
            {
                return 4 * L * h + 2 * L * l;
            }

            public double GetVolume()
            {
                return l * L * h;
            }
        }

    }
}

