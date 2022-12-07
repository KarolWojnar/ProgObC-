using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    public class Shape
    {
        List<Shape> shapes;
        int x, y;
        float width, height;
        public virtual void Draw()
        {
            Console.WriteLine("Próbujesz narysować:");
        }
    }
}
