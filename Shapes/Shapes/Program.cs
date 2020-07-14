using Shapes.Entities;
using Shapes.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int numberOfShapes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfShapes; i++)
            {
                Console.WriteLine($"Shape #{i} data :");
                Console.Write("Rectangule or Circle (r/c)? ");
                char shape = char.Parse(Console.ReadLine());
                Console.Write("What is the color (Black,Blue,Red) ? ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (shape == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Rectangule(width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    shapes.Add(new Circle(radius, color));
                }
                Console.WriteLine();
                Console.WriteLine("Shapes Areas: ");
                foreach (Shape item in shapes)
                {
                    Console.WriteLine(item.Area().ToString("F2",CultureInfo.InvariantCulture));                }
            }
        }
    }
}
