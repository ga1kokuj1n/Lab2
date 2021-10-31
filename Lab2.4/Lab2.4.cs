using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._4
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Вычисление косинуса по ряду Тейлора");
			double x, q;
			while (true)
			{
				try
				{
					Console.Write("Введите значение аргумента cos(x) в радианах (будет приведено к 0 <= x < 2pi): ");
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
					Console.Write("Введите точность вычисления (0 < q < 1): ");
					q = double.Parse(Console.ReadLine());
					if (q <= 0)
						throw new Exception("NotPositive");
					if (q >= 1)
						throw new Exception("TooBig");
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
				catch (Exception e) when (e.Message == "NotPositive")
				{
					Console.WriteLine("Пожалуйста, введите положительное число");
					continue;
				}
				catch (Exception e) when (e.Message == "TooBig")
				{
					Console.WriteLine("Число должно быть меньше 1");
					continue;
				}
				break;
			}//q = ...

			//------------------------------------------------------------------

			long Fact(long num)
			{
				long ans = 1;
				for (long i = 2; i <= num; i++)
					ans *= i;
				return ans;
			}

			while (Math.Abs(x) > 2 * Math.PI)
				x -= 2 * Math.PI * Math.Sign(x);
			double addent = 1;
			double cos = 0;
			for (long i = 2; Math.Abs(addent) >= q; i += 2)
			{
				cos += addent;
				addent = Math.Pow(x, i) / Fact(i) * Math.Pow(-1, i/2);
			}
			Console.WriteLine($"cos({x:n3}) ~= {cos:n3}");
		}
	}
}
