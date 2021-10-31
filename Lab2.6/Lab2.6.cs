using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._6
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите целое число от 1 до 100 включительно: ");
			int num = 0;
			t1:
			try {
				num = int.Parse(Console.ReadLine());
				if (num < 1 || num > 100)
					throw new Exception();
			}
			catch
			{
				Console.WriteLine("Пожалуйста, введите целое число от 1 до 100!");
				goto t1;
			}

//--------------------------------------------------------------------------------------------------------------------------------------------------------

			Console.Write(num);
			if ((num % 10 >= 5 && num % 10 <= 9) || num % 100 == 0 || (num >= 11 && num <= 19))
				Console.WriteLine(" лет");
			else if (num % 10 == 1)
				Console.WriteLine(" год");
			else
				Console.WriteLine(" года");
		}
	}
}
