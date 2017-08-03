using System;

namespace Abstract_Class
{
   public abstract class GeometricShape
    {
        protected double radius;

        public GeometricShape(double radius)
        {
            radius = radius; 
        }
            public abstract double getArea();
            public abstract double getCircumference();
    }
    public class Circle: GeometricShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = 4.77;
        }
        public double getArea()
        {
            return Math.PI * Math.Pow(radius, 2.0);
        }
        public double getCircumference()
        {
            return Math.PI * 2 * radius;
        }
    }
        
       public  static void Main(string[] args)
        {
            
        }
    }
