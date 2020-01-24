 using System;


namespace Ejercicio0203
{
    class Program
    {
        static void Main()
        {
            //desafio 0203
            Console.WriteLine("Resolver el triangulo rectangulo conociendo el angulo c y el lado z");
            Console.WriteLine("Ingrese el valor de c y presione enter para continuar");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de z y presione enter para continuar");
            double z = double.Parse(Console.ReadLine());

            //c de grados a radianes 
            double cRad = c * (Math.PI / 180);

            //lado y
            double y = (3 / Math.Tan(cRad));
            Console.WriteLine("Lado y: " + y);

            //lado z 
            double t = Math.Sqrt((z * z) + (y * y));
            Console.WriteLine("Lado t: " + t);

            //angulo a conociendo c 
            double a = 180 - c - 90;
            Console.WriteLine("Angulo a: " + a);

        }
    }
}
