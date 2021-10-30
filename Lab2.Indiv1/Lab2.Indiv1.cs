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
			Console.WriteLine("Данная программа вычисляет, в какой четверти находится точка");

			double x, y;
			while (true)
			{
				try
				{
					Console.Write("Введите абсциссу точки: ");
					x = double.Parse(Console.ReadLine());
				}
				catch (FormatException)
				{
					Console.WriteLine("Пожалуйста, введите число! (Используйте ',' как разделитель дробной части)");
					continue;
				}
				catch (OverflowException)
				{
					Console.WriteLine("К сожалению, мантисса это числа больше, чем возможно обработать. Попоробуйте другое.");
					continue;
				}
				break;
			}//x = ...
			while (true)
			{
				try
				{
					Console.Write("Введите ординату точки: ");
					y = double.Parse(Console.ReadLine());
				}
				catch (FormatException)
				{
					Console.WriteLine("Пожалуйста, введите число! (Используйте ',' как разделитель дробной части)");
					continue;
				}
				catch (OverflowException)
				{
					Console.WriteLine("К сожалению, мантисса это числа больше, чем возможно обработать. Попоробуйте другое.");
					continue;
				}
				break;
			}//y = ...

			//------------------------------------------------------------------

			if (x == 0 || y == 0)
			{
				Console.WriteLine("0");
				return;
			}

			if (x > 0)
            {
				if (y > 0)
                    Console.WriteLine("1");
				else
                    Console.WriteLine("4");
            }
			else
            {
				if (y > 0)
                    Console.WriteLine("2");
				else
                    Console.WriteLine("3");
            }
				
		}
	}
}
