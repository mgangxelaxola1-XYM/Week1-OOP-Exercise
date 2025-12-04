using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_OOP_Exercise.ShapeModule
{
    public class Circle : IShape
    {
        
        public double Radius { get; set; }

        // Constructor - demonstrates constructors requirement
        public Circle(double radius)
        {
            Radius = radius;
        }

        // Implementation of the IShape method.
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
