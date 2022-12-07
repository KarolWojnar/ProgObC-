using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Prostokąt");
        }
    }
}
