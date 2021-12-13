using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    class Circle
    {
        double radius;
        //const double PI = 3.415; //(este definita in cals Math)

        public void SetRadius(double radius)
        {
            this.radius = radius;//this se refera la proprietatile clasei curente
        }
        public double GetArea()
        {
          //  Math PI
          //  Math PI
            return Math.PI * Math.Pow(radius, 2);
        }

        public void PrintCircle()
        {
            Console.WriteLine("Circle sith radius {0} has the area {1}", radius, GetArea());
        }
    }
}
