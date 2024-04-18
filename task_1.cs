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
            Console.WriteLine("Введіть число");
            int n = int.Parse(Console.ReadLine());

            if (n > 0)
            {
                while (n > 0)
                {
                Console.WriteLine("Горкун Олександр");
                n--;
                }
            }
            else
            {
                Console.WriteLine("Введіть додатне число");
            }
            
        }
    }
}
