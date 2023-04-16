using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Triangle : Shape
    {

        public override double GetArea()
        {
            return 0.5 * Base * Height;
        }
        public override double GetPerimeter()
        {
            return Side1 + Side2 + Side3;
        }
    }
}
