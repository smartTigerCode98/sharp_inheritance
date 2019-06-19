using System;
using System.Collections.Generic;
using InheritanceApp.Details;
using InheritanceApp.Enums;
using InheritanceApp.Intefaces;

namespace InheritanceApp
{
	class Program
	{
		static void Main(string[] args)
		{
			var figures = new List<IFigure>
			{
				new Square { Side = 4 },
				new Square { Side = 5 },
				new Square { Side = 6 },
				new Rectangle
				{
					Width  = 2,
					Height = 3
				},
				new Rectangle
				{
					Width  = 10,
					Height = 8
				},
				new ColoredSquare
				{
					Color = Color.Blue,
					Side  = 322
				}
			};

			foreach (var figure in figures)
			{
				PrintFigure(figure);
			}

			// A
			// B is A
			//B is a part of A

			var square = new Square { Side = 322 };
			var rectangle = new Rectangle
			{
				Width  = 322,
				Height = 1488
			};

			Console.WriteLine(square.Equals(rectangle));
		}

		private static void PrintFigure(IFigure figure)
		{
			Console.WriteLine($"{figure.GetType().Name} | Area: {figure.Area} | Perimeter: {figure.Perimeter}");
		}
	}
}