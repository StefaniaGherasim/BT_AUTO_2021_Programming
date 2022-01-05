using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    class Shape : AbstractShape
    {
        ConsoleColor color;

        protected void Test()
        {

        }

        public override void Draw()
        {
            Console.WriteLine(" We are drowing a shape!");
        }

        public virtual void Erase()
        {
            Console.WriteLine("We are erasing the shape! ");
        }

        public ConsoleColor GetColor()
        {
            return color;
        }

        public void SetColor(ConsoleColor color)
        {
            this.color = color;
        }
        public override string ToString()
        {
            return "This is a generic shape !! ";
        }

        public override void Color()
        {
            Console.WriteLine("Coloring a shape");
        }


    }
}
