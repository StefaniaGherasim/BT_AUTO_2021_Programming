using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    interface IShape
    {
        void Draw();//o semnatura a unei functii, ( nu se pune piblic --nu i se poate restrange accestul in clasa in care se implementeaza)
        void Color();

        //se poate implementa doar din C#8 (THis is valid only for C# >= 8)
        void State()
        {
            Console.WriteLine("state of the Shape");
        }
        
    }
}
