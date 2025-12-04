using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_OOP_Exercise.ShapeModule
{
    //Class
    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        //Constructor
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        // Interface method implementation.
        public double CalculateArea()
        {
            return Width * Height;
        }
    }
}
