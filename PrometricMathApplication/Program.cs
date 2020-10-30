using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PrometricMathApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<Shape> shapes = GetShapes();

            Console.WriteLine("SHAPES ORDERED BY PERIMETER");
            shapes = shapes.OrderBy(shape => shape.Perimiter()).ToList();
            Print(shapes);

            Console.WriteLine("\n\n\n");

            Console.WriteLine("SHAPES ORDERED BY SURFACE AREA");
            shapes = shapes.OrderBy(shape => shape.SurfaceArea()).ToList();
            Print(shapes);

            WriteToJSON(shapes);

            GetTypes(shapes);

        }

        public static void Print(List<Shape> shapes)
        {
            Console.WriteLine("NUMBER OF SHAPES: " + shapes.Count);

            foreach (var shape in shapes)
                Console.WriteLine(shape);        
        }

        public static void WriteToJSON(List<Shape> shapes)
        {

            using (StreamWriter sw = File.CreateText("shapes.json"))
            {
                StringBuilder sb = new StringBuilder();

                sb.Append("[");
                for (int i = 0; i < shapes.Count; i++)
                {
                    sb.Append(shapes[i].ToJSON());
                    if (i < shapes.Count-1)
                    {
                        sb.Append(",");
                    }
                }
                sb.Append("]");

                String res = sb.ToString();
                sw.Write(res);
            }
            Console.WriteLine("shapes.json has been generated");
        }

        public static void GetTypes(List<Shape> shapes)
        {
            int circleCount = 0;
            int triangleCount = 0;
            int squareCount = 0;
            int rectangleCount = 0;

            foreach (var shape in shapes)
            {
                if (shape is Circle) circleCount++;
                if (shape is Triangle) triangleCount++;
                if (shape is Square) squareCount++;
                if (shape is Rectangle) rectangleCount++;
            }
            Console.WriteLine($"Circles: {circleCount}, Triangles: {triangleCount}, " +
                    $"Square: {squareCount}, Rectangle {rectangleCount}");
        }

        public static List<Shape> GetShapes()
        {
            var shapes = new List<Shape>();

            Circle c = new Circle{ Radius = 5};
            Triangle t = new Triangle
            {
                A = 41,
                B = 7,
                C = 3,
                Height = 60,
                Base = 41
            };
            Rectangle r = new Rectangle
            {
                Width = 55,
                Height = 44
            };
            Square s = new Square
            {
                Width = 51,
                Height = 86
            };

            shapes.Add(c);
            shapes.Add(t);
            shapes.Add(r);
            shapes.Add(s);

            return shapes;
        }
    }
}
