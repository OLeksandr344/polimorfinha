using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal abstract class Shape
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }
        
        
        public Shape(string name)
        {
            Name = name;
        }
        public abstract double Area();
        public abstract double Perimetr();      
    }
    class Circle : Shape
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override double Perimetr()
        {
            return 2 * Math.PI * Radius;
        }
    }
     class Square : Shape
    {
        
        private double side;

        
        public double Side
        {
            get { return side; }
            set { side = value; }
        }

        
        public Square(string name, double side) : base(name)
        {
            Side = side;
        }

        
        public override double Area()
        {
            return Math.Pow(Side, 2);
        }

        public override double Perimetr()
        {
            return 4 * Side;
        }
    }
}
