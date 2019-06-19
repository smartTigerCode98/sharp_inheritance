using System;

namespace InheritanceApp.Intefaces
{
	public interface IFigure : IEquatable<IFigure>
	{
		double Perimeter { get; }
		double Area      { get; }
	}
}