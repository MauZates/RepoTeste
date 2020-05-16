using System;
using System.Collections.Generic;
using System.Text;
using Shapes.Entities.Enums;

namespace Shapes.Entities
{
    class Rectangule : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangule(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
