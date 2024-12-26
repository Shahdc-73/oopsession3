using System;

namespace InterfaceExample
{
    public interface IShape
    {
        double Area { get; }
        void DisplayShapeInfo();
    }

    public interface ICircle : IShape
    {
        double Radius { get; set; }
    }

    public interface IRectangle : IShape
    {
        double Width { get; set; }
        double Height { get; set; }
    }

    public class Circle : ICircle
    {
        public double Radius { get; set; }
        public double Area => Math.PI * Radius * Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle: Radius = {Radius}, Area = {Area:F2}");
        }
    }

    public class Rectangle : IRectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Area => Width * Height;

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle: Width = {Width}, Height = {Height}, Area = {Area:F2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ICircle circle = new Circle(5.0);
            circle.DisplayShapeInfo();

            
            IRectangle rectangle = new Rectangle(4.0, 6.0);
            rectangle.DisplayShapeInfo();
        }
    }
}
