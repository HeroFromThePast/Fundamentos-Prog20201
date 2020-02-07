using System;

namespace votacionesBool2
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
            int pme = int.Parse(Console.ReadLine());
            //votantes -->  mayores de edad
            int PobMayor = n * (pme / 100);
            int Tvot = a + b + w + anul;
            double abstenencia = Tvot - PobMayor;

            bool C1 = PobMayor < Tvot;
            bool C2 = (a - b) < Tvot * 0.1;
            bool C3 = PobMayor < n * 0.3;
            bool p1 = a > b;
            bool p2 = b > a;

            if ((C1 || C2) && C3) Console.WriteLine("Las votaciones deben hacerse nuevamente");

            else if (p1) Console.WriteLine("El ganador es el Partido 1");

            else if (p2) Console.WriteLine("El ganador es el Partido 2");

            else return;
        }
    }
}
