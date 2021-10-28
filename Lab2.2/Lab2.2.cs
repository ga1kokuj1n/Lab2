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
			long amountOfAddends = 0;
			t1:
			Console.Write("По какому кол-ву слагаемых считаем?: ");
            try
			{
				amountOfAddends = long.Parse(Console.ReadLine());
				if (amountOfAddends <= 0)
					throw new Exception("BelowZero");
			} catch (FormatException)
            {
                Console.WriteLine("Пожалуйста, введите целое число!");
				goto t1;
            } catch (Exception e) when (e.Message == "BelowZero")
            {
                Console.WriteLine("Число слагаемых должно быть больше больше нуля!");
				goto t1;
            } catch (OverflowException)
            {
                Console.WriteLine("К сожалению, это число больше, чем возможно обработать. Попоробуйте другое.");
				goto t1;
            }

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
