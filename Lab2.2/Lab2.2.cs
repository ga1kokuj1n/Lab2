using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Вычисление pi по формуле суммы бесконечного ряда: ");
			long amountOfAddends;
			while (true)
			{
				try
				{
					Console.WriteLine("Введите кол-во элементов, по которому будет произведён рассчёт:");
					amountOfAddends = long.Parse(Console.ReadLine());
					if (amountOfAddends <= 0)
						throw new Exception("NotPositive");

				}
				catch (FormatException)
				{
					Console.WriteLine("Пожалуйста, введите целое число!");
					continue;
				}
				catch (Exception e) when (e.Message == "NotPositive")
				{
					Console.WriteLine("Число слагаемых должно быть больше больше нуля!");
					continue;
				}
				catch (OverflowException)
				{
					Console.WriteLine("К сожалению, это число больше, чем возможно обработать. Попоробуйте другое.");
					continue;
				}
				break;
			}//amountOfAddends = ...

//--------------------------------------------------------------------------------------------------------------------------------------------------------

			decimal ans = 1;
			bool isNegative = true;
			for (long i = 3; i <= amountOfAddends*2 - 1; i += 2)
			{
				if(isNegative)
				{
					ans -= 1 / (decimal)i;
				}else
				{
					ans += 1 / (decimal)i;
				}

				isNegative = !isNegative;
			}
			ans *= 4;
			Console.WriteLine($"Получившееся значение пи - {ans}");
		}
	}
}
