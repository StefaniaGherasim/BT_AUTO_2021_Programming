using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    abstract class AbstractShape : IShape, IIntf
    {
        int x = 0;

        public abstract void Draw();

        public abstract void Color();

        public void DoSomthing()
        {
            Console.WriteLine("Shape is doing something");
        }
    }
}
