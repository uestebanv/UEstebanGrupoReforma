using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Factorial
    {
        public static void NumeroFactorial()
        {
            int result = 1;
            Console.WriteLine("Ingrese el numero que desea sacar el factorial: ");
            int num = int.Parse(Console.ReadLine());

            for(int a = 1; a<=num; a++)
            {
                result *= a;
            }

            Console.WriteLine("El resultado es: " + result);
            Console.ReadKey();
        }
    }
}
