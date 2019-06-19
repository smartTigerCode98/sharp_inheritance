using InheritanceApp.Intefaces;

namespace InheritanceApp.Details
{
	public class Rectangle : IFigure
	{
		public double Width  { get; set; }
		public double Height { get; set; }

		public double Perimeter => 2 * Width + 2 * Height;
		public double Area      => Width * Height;

		public bool Equals(IFigure other)
		{
			if (!(other is Rectangle rectangle))
			{
				return false;
			}

			if (rectangle == this)
			{
				return true;
			}

			return rectangle.Width.Equals(Width) && rectangle.Height.Equals(Height);
		}
	}
}