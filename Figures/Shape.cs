using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Radius { get; set; }
        public double Side { get; set; }
        public double Base { get; set; }
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }
        public abstract double GetArea();
        public abstract double GetPerimeter();
    }
}
