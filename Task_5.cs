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

            Console.WriteLine("Горкун Олександр");
            
            double x, y;
            double step = 0.2;

            // Вивід заголовка таблиці
            Console.WriteLine("x\ty = sin(x) / ln(x + 4)");
            Console.WriteLine("--------------------------");

            // Розрахунок та вивід значень функції
            for (x = -2; x <= 5; x += step)
            {
                if (x == 0)
                {
                    y = double.NaN; // Функція не визначена при x = 0
                }
                else
                {
                    y = Math.Sin(x) / Math.Log(x + 4);
                }

                Console.WriteLine("{0:F2}\t{1:F4}", x, y);

            }   
        }
    }
}
