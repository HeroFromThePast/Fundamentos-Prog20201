using System;


namespace eulerprog
{
    class Program
    {
        static void Main()
        {
            double x = 0;
            double ExpX = 0;
           // double iFact = factorial(i);
            Console.WriteLine("ingrese el valor de x");
            x = double.Parse(Console.ReadLine());
            
            
            for (int i = 0; i < 1000; i++)
            {
                double resultadoant = 0;
                ExpX +=  Math.Pow(x, i) / factorial(i);
                resultadoant += ExpX;
                Console.WriteLine(resultadoant);

            }
           
        }

        public static double factorial(double number)
        {
            if (number == 0) return 1; 
            if (number == 1) return 1;
            else return number * factorial(number - 1);
        }
    }
}
