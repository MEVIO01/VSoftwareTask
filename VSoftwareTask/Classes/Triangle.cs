using System;
using System.Collections.Generic;
using System.Text;

namespace VSoftwareTask.Classes
{
    class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public Triangle(double triangleBase, double height)
        {
            this.Base = triangleBase;
            this.Height = height;
        }
        public override double CalculateArea()
        {
            return this.Base * (this.Height / 2D);
        }
    }
}
