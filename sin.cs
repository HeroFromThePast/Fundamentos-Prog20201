using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinprog
{
    class Program
    {
        static void Main()
        {
            double x = 0;
            double resultado = 0;
            
            Console.WriteLine("ingrese el valor de x");
            x = double.Parse(Console.ReadLine());

            for (int i = 0; i < 1000; i++)
            {
                double sen = 0;
                resultado += (Math.Pow(-1, i) / factorial(((2 * i) + 1))) * (Math.Pow(x, (2 * i) + 1));
                sen += resultado;
                
             
            }
            Console.WriteLine(sen);
        }





        public static double factorial(double number)
        {
            if (number == 0) return 1;
            if (number == 1) return 1;
            else return number * factorial(number - 1);
        }
    }
}
