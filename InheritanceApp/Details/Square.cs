using System;
using InheritanceApp.Intefaces;

namespace InheritanceApp.Details
{
	public class Square : IFigure
	{
		private double _side;

		public double Side
		{
			get => _side;
			set
			{
				if (value <= 0)
				{
					throw new ArgumentException("Side cannot be less than 0");
				}

				_side = value;
			}
		}

		public double Perimeter => _side * 4;

		public double Area => Math.Pow(_side, 2);

		public virtual bool Equals(IFigure other)
		{
			if (!(other is Square square))
			{
				return false;
			}

			if (square == this)
			{
				return true;
			}

			return _side.Equals(square._side);
		}
	}
}