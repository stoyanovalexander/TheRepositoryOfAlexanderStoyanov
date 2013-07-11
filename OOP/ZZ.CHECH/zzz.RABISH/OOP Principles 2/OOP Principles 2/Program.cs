using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Principles_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> sList = new List<Shape>();

            Triangle t = new Triangle(3, 4);
            Rectangle r = new Rectangle(3, 4);
            Circle c = new Circle(4);

            sList.Add(t);
            sList.Add(r);
            sList.Add(c);

            Console.WriteLine("Surfaces - first Triangle, second Rectangle, third Circle");
            Console.WriteLine();
            foreach (Shape s in sList)
            {
                Console.WriteLine("Surface area: {0}",s.CalculateSurface());
            }
        }
    }

    /// <summary>
    /// Abstract class Shape
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// Abstract method for calculting the surface
        /// </summary>
        /// <returns>the shape area</returns>
        public abstract double CalculateSurface();
    }

    /// <summary>
    /// Class Triangle - inheriting class Shape
    /// </summary>
    public class Triangle:Shape
    {
        private double width;
        private double height;

        /// <summary>
        /// Method for calculating the surface of an area
        /// </summary>
        /// <returns>the surface of the shape</returns>
        public override double CalculateSurface()
        {
            double surface=width*height/2;
            return surface;
        }

        /// <summary>
        /// Constructor for the class Triangle
        /// </summary>
        /// <param name="Width">width of the shape</param>
        /// <param name="Height">height of the shape</param>
        public Triangle(double Width, double Height)
        {
            width = Width;
            height = Height;
        }
    }

    /// <summary>
    /// Class Rectangle - inheriting class Shape
    /// </summary>
    public class Rectangle:Shape
    {
        private double width;
        private double height;

        /// <summary>
        /// Method for calculating the surface of an area
        /// </summary>
        /// <returns>surface of the shape</returns>
        public override double CalculateSurface()
        {
            double surface=width*height;
            return surface;
        }

        /// <summary>
        /// Constructor for the class Rectangle
        /// </summary>
        /// <param name="Width">width of the shape</param>
        /// <param name="Height">height of the shape</param>
        public Rectangle(double Width, double Height)
        {
            width = Width;
            height = Height;
        }
    }

    /// <summary>
    /// Class Circle = inheriting class Shape
    /// </summary>
    public class Circle:Shape
    {
        private double width;
        private double height;

        /// <summary>
        /// Method for claculating the surface of an area
        /// </summary>
        /// <returns>surface of the shape</returns>
        public override double CalculateSurface()
        {
            double surface = width * height * Math.PI;
            return surface;
        }

        /// <summary>
        /// Constructor of the class Circle
        /// </summary>
        /// <param name="radius">radius of the circle</param>
        public Circle(double radius)
        {
            width = radius;
            height = radius;
        }
    }
}
