using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Votos por partido 1");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Votos por partido 2");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Votos en blanco");
            int w = int.Parse(Console.ReadLine());

            Console.WriteLine("Votos anulados");
            int anul = int.Parse(Console.ReadLine());

            Console.WriteLine("poblacion total");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("porcentaje poblacion mayor de edad");
            int p = int.Parse(Console.ReadLine());
            //votantes -->  mayores de edad
            int pme = n * (p / 100);
            int Tvot = a + b + w + anul;
            double abs = Tvot - pme;

            bool C1 = anul < 0.3 * (a + b);
            bool C2 = a + b > w;
            bool C3 = abs < Tvot;
            bool p1 = a < b;
            bool p2 = b < a;

            Console.WriteLine("total votos " + Tvot);
            Console.WriteLine("votos en blanco " + w);
            Console.WriteLine("abstenencia " + abs);
            Console.WriteLine("anulados " + Tvot);


            if (((C1 || C2) && C3) && p1)
                Console.WriteLine("El partido ganador es el 1");

            else if (((C1 || C2) && C3) && p2)
                Console.WriteLine("El partido ganador es el 2");

            else Console.WriteLine("Las votaciones deben realizarce nuevamente");













        }
    }
}
