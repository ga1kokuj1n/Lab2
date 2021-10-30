using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Решение ax^2 + bx + c = 0");
			Console.Write("Введите a: ");
			double a, b, c;
			while (true)
            {
                try
                {
					Console.WriteLine("Введите значение a: ");
					a = double.Parse(Console.ReadLine());
                }
				catch (FormatException)
                {
                    Console.WriteLine("Пожалуйста, введите число!");
					continue;
                }
				break;
            }//a = ...
			while (true)
            {
                try
                {
					Console.Write("Введите значение b: ");
					b = double.Parse(Console.ReadLine());
                }
                catch
                {
					Console.WriteLine("Пожалуйста, введите число!");
					continue;
				}
				break;
			}//b = ...
			while (true)
            {
                try
                {
					Console.Write("Введите значение с: ");
					c = double.Parse(Console.ReadLine());
                }
                catch
                {
					Console.WriteLine("Пожалуйста, введите число!");
					continue;
				}
				break;
            }//c = ...

			double disc = b * b - 4 * a * c;
			if (disc == 0)
			{
				double x = -b / (2 * a);
				Console.WriteLine($"2 совпадающих действительных корня:\nx1 = x2 = {x}");
			}
			else if (disc > 0)
			{
				double x1 = (-b + Math.Sqrt(disc)) / (2 * a);
				double x2 = (-b - Math.Sqrt(disc)) / (2 * a);
				Console.WriteLine($"2 действительных корня:\nx1 = {x1}\nx2 = {x2}");
			}
			else
			{
				double real = -b / (2 * a);
				double imag = Math.Sqrt(-disc);
                Console.WriteLine($"2 комплексных корня:\nx1 = {real} + {imag}i\nx2 = {real} - {imag}i");
			}
		}
	}
}
