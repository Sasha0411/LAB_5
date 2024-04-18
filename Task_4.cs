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

            int positiveCount = 0;
            int negativeCount = 0;
            int sum = 0;

            int number;

            do
            {
                Console.Write("Введіть число: ");
                number = int.Parse(Console.ReadLine());

                if (number > 0)
                {
                    positiveCount++;
                }
                else if (number < 0)
                {
                    negativeCount++;
                }

                sum += number;

            } while (number != 0);

            Console.WriteLine("Кількість введених додатніх чисел: {0}", positiveCount);
            Console.WriteLine("Кількість введених від'ємних чисел: {0}", negativeCount);
            Console.WriteLine("Сума введених чисел: {0}", sum);
        }
    }
    
}
