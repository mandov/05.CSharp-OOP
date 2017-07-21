namespace Shapes
{
    using System;

    public abstract class Shape
    {
        private double width;

        private double height;

        public Shape()
        {

        }

        public Shape(double width, double height)
        {
            if (width <= 0 || height <= 0)
            {
                throw new ArgumentException("The values must be greater than 0 !");
            }
            this.width = width;
            this.height = height;

        }

        public abstract double CalculateSurface();

        public double Width
        {
            get { return this.width; }           
        }

        public double Height 
        {
            get { return this.height; }        
        }
    }
}