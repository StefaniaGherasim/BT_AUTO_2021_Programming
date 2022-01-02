using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    class Triangle : Shape
    {
        int l1, l2, l3;

        public Triangle(int l1, int l2, int l3)
        {
            this.l1 = l1;
            this.l2 = l2;
            this.l3 = l3;
        }

        public Triangle()
        {

        }

        public void FlipVertical()
        {

        }

        public void FlipHorizontal()
        {

        }

        public override string ToString()
        {
            return "Triangle has the following sizes: " + l1 + " " + l2 + " " +l3;
        }
    }
}
