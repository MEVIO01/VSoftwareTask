using System;
using System.Collections.Generic;
using System.Text;

namespace VSoftwareTask.Classes
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height)
        {
            this.Height = height;
            this.Width = width;
        }
        public override double CalculateArea()
        {
            return this.Width * this.Height;
        }
    }
}
