using System;
using System.Collections.Generic;
using System.Text;

namespace VSoftwareTask.Classes
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public override double CalculateArea()
        {
            return this.Radius * this.Radius * Math.PI;
        }
    }
}
