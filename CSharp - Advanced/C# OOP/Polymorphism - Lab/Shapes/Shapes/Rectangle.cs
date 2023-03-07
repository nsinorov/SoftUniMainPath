
namespace Shapes
{
    public class Rectangle : Shape
    {
		private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Width
        {
			get => width;
			private set { width = value; } // TODO validation 
		}
		public double Height
        {
			get => height;
			set { height = value; } // TODO validation 
        }

        public override double CalculateArea() => Width * Height;

        public override double CalculatePerimeter() => 2 * (Height + Width); 

    }
}
