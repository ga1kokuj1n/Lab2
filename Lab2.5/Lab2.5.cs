using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Эта программа раскладывает натуральное число на три куба натуральных чисел и выводит эти числа");

			long N;
			while (true)
			{
				try
				{
					Console.Write("Введите натуральное число: ");
					N = long.Parse(Console.ReadLine());
					if (N < 1)
						throw new Exception("NotNatural");
				}
				catch (FormatException)
				{
					Console.WriteLine("Пожалуйста, введите натуральное число!");
					continue;
				}
				catch (Exception e) when (e.Message == "NotNatural")
				{
					Console.WriteLine("Пожалуйста, введите натуральное число!");
					continue;
				}
				break;
			}//N = ...

//--------------------------------------------------------------------------------------------------------------------------------------------------------

			//В этих случаях разложение невозможно, а алгоритм, скорее всего, будет вести себя некорректно
			if (N <= 2)
			{
				Console.WriteLine("No such combination!");
				return;
			}

			//Простой перебор вариантов (я так и не придумал, как это по другому написать)
			bool isFound = false;
			for (long i = 1; i <= N - 2; i++)
				for (long j = 1; j <= N - 2; j++)
					for (long k = 1; k <= N -2; k++)
						if (Math.Pow(i, 3) + Math.Pow(j, 3) + Math.Pow(k, 3) == N)
						{
							Console.WriteLine($"{i}, {j}, {k}");
							isFound = true;
						}
			if (!isFound)
				Console.WriteLine("No such combination");
		}
	}
}
