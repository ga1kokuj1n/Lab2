using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Indiv1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите координаты точки");
			double x = 0, y = 0;
			string x_str, y_str;
			t1:
			Console.Write("x: ");
			x_str = Console.ReadLine();
            try { x = double.Parse(x_str); }
			catch (FormatException)
            {
                Console.WriteLine("Введите действительное число!");
				goto t1;
            }
			t2:
			Console.Write("y: ");
			y_str = Console.ReadLine();
            try { y = double.Parse(y_str); }
			catch (FormatException)
            {
                Console.WriteLine("Введите действительное число!");
				goto t2;
            }

		}
	}
}
