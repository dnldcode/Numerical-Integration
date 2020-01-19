using Project4.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Console.WriteLine("Please write the coefficients of polynomial function:");
				String input = Console.ReadLine();
				Polynomial polynomial = new Polynomial(input);
				Console.WriteLine("The function you've entered:");
				Console.WriteLine(polynomial);
				Console.WriteLine("Please write the boundaries of integration:");
				Console.Write("a = ");
				double a = Int32.Parse(Console.ReadLine());
				Console.Write("b = ");
				double b = Int32.Parse(Console.ReadLine());
				Integration integration = new Integration(polynomial);
				Console.WriteLine("Ingeration by trapezoidal method: " + integration.GetIntegralTrapeze(a, b));
				Console.WriteLine("Ingeration by Simpson's method: " + integration.GetIntegralSimpson(a, b));

			}
			catch (Exception e)
			{
				Console.WriteLine("Error occured: " + e.Message);
			}
		}
	}
}
