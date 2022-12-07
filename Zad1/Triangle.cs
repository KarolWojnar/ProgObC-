using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    public class Triangle : Shape
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Trójkąt");
        }
    }
}
