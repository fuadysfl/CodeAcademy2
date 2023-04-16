using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Square : Shape
    {
        public override double GetArea()
        {
            return Side * Side;
        }
        public override double GetPerimeter()
        {
            return 4 * Side;
        }
    }
}
