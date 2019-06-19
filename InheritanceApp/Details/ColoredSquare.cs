using InheritanceApp.Enums;
using InheritanceApp.Intefaces;

namespace InheritanceApp.Details
{
	public class ColoredSquare : Square, IColorEquatable<ColoredSquare>
	{
		public Color Color { get; set; }

		public override bool Equals(IFigure other)
		{
			if (!(other is ColoredSquare coloredSquare))
			{
				return false;
			}

			return Equals(coloredSquare) && base.Equals(coloredSquare);
		}

		public bool Equals(ColoredSquare other)
		{
			if (other == null)
			{
				return false;
			}

			return Color == other.Color;
		}
	}
}