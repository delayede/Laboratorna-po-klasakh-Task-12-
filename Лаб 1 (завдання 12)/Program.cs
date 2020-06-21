using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб_1__завдання_12_
{

    public class Circle
    {
        public double Radius { get; set; }
        public Point Center { get; set; }

        public Circle(double radius, Point center)
        {
            Radius = radius;
            Center = center;
        }

        public double CircleArea
        {
            get { return Math.PI * Radius * Radius; }
        }

        public double Circumference
        {
            get { return Math.PI * 2 * Radius; }
        }

        public bool IsInside(Point point)
        {
            Point vector = new Point(point.X - Center.X, point.Y - Center.Y);
            double distance = vector.X * vector.X + vector.Y * vector.Y;
            return distance <= Radius * Radius;
        }

        public override string ToString()
        {
            return String.Format("Radius: {0}; Center: {1};", Radius, Center);
        }
    }

    public class Point
    {
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; private set; }
        public double Y { get; private set; }

        public override string ToString()
        {
            return string.Format("({0}, {1})", X, Y);
        }
    }
    class program {
        static void Main()
        {
            Circle circle = new Circle(1, new Point(0, 0));

            Console.WriteLine("Перевірка на приналежність точки {0}", circle.IsInside(new Point(0.1, 0.1)));
            Console.WriteLine("Площа = {0}", circle.CircleArea);
            Console.WriteLine("Довжина окружності = {0}", circle.Circumference);

            Console.ReadKey();
        } }}