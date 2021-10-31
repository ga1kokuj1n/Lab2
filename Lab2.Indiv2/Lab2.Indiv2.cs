using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Indiv2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Эта программа показывает все чётные делители числа");

			long num;
			while (true)
			{
				try
				{
					Console.Write("Введите натуральное число от 1 до 10000: ");
					num = long.Parse(Console.ReadLine());
					if (num < 1)
						throw new Exception("BelowDiap");
					else if (num > 10000)
						throw new Exception("AboveDiap");
				}
				catch (FormatException)
				{
					Console.WriteLine("Пожалуйста, введите натуральное число!");
					continue;
				}
				catch (Exception e) when (e.Message == "BelowDiap" || e.Message == "AboveDiap")
				{
					Console.WriteLine("Пожалуйста, введите число от 1 до 10000");
					continue;
				}
				catch (OverflowException)
				{
					Console.WriteLine("Пожалуйста, введите число от 1 до 10000");
					continue;
				}
				break;
			}//num = ...

			//------------------------------------------------------------------

			List<long> dividers = new List<long>();
			for (long i = 2; i <= num; i++)
				if (num % i == 0 && i % 2 == 0)
					dividers.Add(i);
			
			foreach (long i in dividers)
			{
				Console.Write(i + ", ");
			}
			Console.WriteLine("\b\b\0\0");
		}
	}
}
