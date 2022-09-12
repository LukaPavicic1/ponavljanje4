using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vježbanje4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y; 
            int z;

            Console.WriteLine("Upiši stranicu trokuta: ");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z = Convert.ToInt32(Console.ReadLine());

            if ((x * x) + (y * y) == (z * z) || (x * x) + (z * z) == (y * y) || (y * y) + (z * z) == (x * x))
            {
                Console.WriteLine("To je Pravokutni trokut\n");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("To nije pravokutni trokut\n");
                Console.ReadKey();
            }
        }
    }
}
