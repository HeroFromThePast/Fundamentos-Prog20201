using System;

namespace Ejercicio0202
{
    class Program
    {
        static void Main()
        {
            //desafio 02 02
            Console.WriteLine("Resolver el triangulo rectangulo conociendo el angulo a y el lado t");
            Console.WriteLine("Ingrese el valor del angulo a y presione enter para continuar");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del lado t y presione enter para continuar");
            double t = double.Parse(Console.ReadLine());

            //angulo c conociendo a 
            double c = 180 - a - 90;
            Console.WriteLine("Angulo c: " + c);

            // angulos de grados a radianes 
            double cRad = c * (Math.PI / 180);
            double aRad = a * (Math.PI / 180);
      
            //lado z
            double z = t * (Math.Cos(aRad));
            Console.WriteLine("Lado Z: " + z);

            //lado y
            double y = Math.Sqrt((t * t) - (z * z));
            Console.WriteLine("Lado y: " + y);


            
        }
    }
}
