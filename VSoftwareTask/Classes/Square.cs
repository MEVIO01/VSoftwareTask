using System;
using System.Collections.Generic;
using System.Text;

namespace VSoftwareTask.Classes
{
    class Square : Shape
    {
        public double Side { get; set; }
        public Square(double side)
        {
            this.Side = side;
        }
        public override double CalculateArea()
        {
            return Side * Side;
        }
    }
}
