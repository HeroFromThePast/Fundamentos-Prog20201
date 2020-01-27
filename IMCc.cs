using System;


namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Calculadora indice de masa corporal");
            Console.WriteLine("Ingrese su estatura en metros");
            double h = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su peso en kilogramos");
            double W = double.Parse(Console.ReadLine());

            double IMC = W / (h * h);

            if (IMC < 18.5)
            {
                Console.WriteLine("su IMC es de " + IMC + ", está por debajo de lo normal");
            }
            else if (18.5 <= IMC && IMC <= 24.9)
            {
                Console.WriteLine("su IMC es de " + IMC + ", Normal");
            }
            else if (25 <= IMC && IMC <= 29.9) 
            {
                Console.WriteLine("su IMC es de " + IMC + ", está por encima de lo normal");
            }
            else 
            {
                Console.WriteLine("su IMC es de " + IMC + ", Usted está obeso");
            }


        }
    }
}
