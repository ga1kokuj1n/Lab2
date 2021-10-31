using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._3
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 1, b = 1, c = 0;
			while (c < 1000)
			{
				c = a + b;
				a = b;
				b = c;
			}
			int count = 0;
			while (c < 9999)
			{
				c = a + b;
				a = b;
				b = c;
				count++;
			}
			Console.WriteLine($"В ряде Фибоначчи {count} четырёхзначных чисел");
		}
	}
}
