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

            //В этих случаях разложение невозможно, а алгоритм, скорее всего, будет вести себя некорректно
            if (N <= 2)
            {
                Console.WriteLine("No such combination!");
                return;
            }


        }
    }
}
