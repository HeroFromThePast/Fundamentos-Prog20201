using System;


namespace Ejercicio0201
{
    class Program
    {
        static void Main()
        {
            //desafio 02 01
            //se conocen dos de los lados del triangulo
            Console.WriteLine("Resolver el triangulo rectangulo conociendo los lados Y y Z");
            Console.WriteLine("Ingrese el valor del lado Y y presione enter para continuar");          
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del lado Z y presione enter para continuar");
            double z = double.Parse(Console.ReadLine());

            //hipotenuza 
            double t = Math.Sqrt((y * y) + (z * z));
            Console.WriteLine("Lado T: " + t);

            //angulo c
            double SinC = z / t;
            double c = Math.Asin(SinC);
            double cDeg = c * (180 / Math.PI);
            Console.WriteLine("Angulo c: " + cDeg);

            //angulo a 
            double SinA = y / t;
            double a = (Math.Asin(SinA));
            double aDeg = a * (180 / Math.PI);
            Console.WriteLine("Angulo a: " + aDeg);

            Console.WriteLine("Todos los angulos estan en radianes");          
        }
    }
}
