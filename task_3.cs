using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Горкун Олексвндр");

            // Введення значень k та x
            Console.Write("Введіть k: ");
            int k = int.Parse(Console.ReadLine());

            Console.Write("Введіть x: ");
            double x = double.Parse(Console.ReadLine());

            // Обчислення x^k за допомогою циклу
            double result = 1;
            for (int i = 0; i < k; i++)
            {
                result *= x;
            }

            // Виведення результату
            Console.WriteLine($"{x}^{k}={result}");
        }
    }
}
