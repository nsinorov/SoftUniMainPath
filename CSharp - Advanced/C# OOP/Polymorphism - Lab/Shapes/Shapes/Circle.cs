
namespace Shapes
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Radius
        {
            get => radius;
            private set { radius = value; } // TODO validation 
        }

        public override double CalculateArea() => Math.PI * Math.Pow(Radius, 2);

        public override double CalculatePerimeter() => 2 * Math.PI * Radius;
    }
}
