using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace VSoftwareTask.Classes
{
    abstract class Shape : IComparable<Shape>
    {
        public int CompareTo(Shape shape)
        {
            return this.CalculateArea().CompareTo(shape.CalculateArea());
        }

        public abstract double CalculateArea();
    }
}
