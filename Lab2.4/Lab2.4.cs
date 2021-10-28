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
			double x = 0, q = 0;
			t1:
			try
			{
				Console.Write("Введите значение аргумента cos(x): ");
				x = double.Parse(Console.ReadLine());
			} catch (FormatException)
			{
				Console.WriteLine("Введите число!");
				goto t1;
            } catch (OverflowException)
            {
                Console.WriteLine("Такое большое число невозможно обработать. Попробуйте другое.");
				goto t1;
            } //Присвоение x
			t2:
            try
            {
				Console.Write("Введите точность вычисления: ");
				q = double.Parse(Console.ReadLine());
            } catch (FormatException)
            {
                Console.WriteLine("Введите число!");
				goto t2;
            } catch (OverflowException)
            {
				Console.WriteLine("Такое большое число невозможно обработать. Попробуйте другое.");
				goto t2;
            } //Присовение q

			ulong Fact(ulong num)
            {
				ulong fact = 1;
				for (uint i = 1; i <= num; i++)
                {
					fact *= i;
                }
				return fact;
            }
			double ans = 1, add = 0;
			ulong addCounter = 1;
			do
			{
				add = Math.Pow(x, addCounter * 2) / Fact(addCounter * 2);
				ans += add * (addCounter % 2 == 0 ? 1 : -1);
				addCounter++;
			} while (add >= q);

            Console.WriteLine($"cos({x}) ≈ {ans}");
		}
	}
}
