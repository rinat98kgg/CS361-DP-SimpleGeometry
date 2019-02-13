﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryLib;
using GeometryLib.Shapes;

namespace GeometryLib
{
    public static class ShapePrinter
    {
        public static void Print(Shape shape)
        {
            double area = 0;

            if (shape is Circle)
            {
                var circle = (Circle) shape;
                //area = circle.Radius * circle.Radius * Math.PI;
                Console.WriteLine(circle.Print());
            }
            else if (shape is RightAngledTriangle)
            {
                var rightTriangle = (RightAngledTriangle) shape;
                //area = 0.5 * rightTriangle.Side1 * rightTriangle.Side2;
                //var info = "Right-angled Triangle: ";
                //info += $"sides {rightTriangle.Side1} {rightTriangle.Side2} {rightTriangle.Side3}, ";
                //info += $"area = {area}";
                Console.WriteLine(rightTriangle.Print());
            }
            else if (shape is Triangle)
            {
                var triangle = (Triangle) shape;

                //var side1 = triangle.Side1;
                //var side2 = triangle.Side2;
                //var side3 = triangle.Side3;
                //var p = (side1 + side2 + side3) / 2;
                //area = Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
                //Console.WriteLine($"Triangle: sides: {side1} {side2} {side3}, area = {area}");
                Console.WriteLine(triangle.Print());
            }
        }
    }
}
