using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    class Rectangle : Shape
    {
        double length;
        double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public Rectangle()
        {

        }
          

        public void SetSize(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public virtual double GetArea()
        {
            return length * width;
        }
        public void PrintRectangle()
        {
            Console.WriteLine("The rectangule sith length {0} and width {1} has arae {2}", length, width, GetArea());
        }

        public override string ToString()
        {
            return "This is a rectangle with  " + width + "width and" + length + "length !!";
        }
    }
}
