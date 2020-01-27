using System;


namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Resolver la ecuacion cuadrática");
            Console.WriteLine("ingrese el valor de A");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el valor de B");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el valor de C");
            double c = double.Parse(Console.ReadLine());

            double disc = (Math.Pow(b, 2) - (4 * a * c));

            if (disc == 0)
            {
                double x1 = -b / (2 * a);
                Console.WriteLine("la solucion existe y es unica ");
            }
            else if (disc > 0)
            {
                double x1 = (-b + disc) / (2 * a);
                double x2 = (-b - disc) / (2 * a);
                Console.WriteLine("Existen dos posibles soluciones correctas");
                Console.WriteLine("x1= " + x1 + ", x2= " + x2);
            }
            else 
            {              
                Console.WriteLine("la solucion no existe ");
            }
        }
    }
}
