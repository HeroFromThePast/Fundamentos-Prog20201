using System;


namespace _21
{
    class Program
    {
        static void Main()
        {
            int puntos = 0;
            Random random = new Random();
            int carta1 = random.Next(1, 11);
            int carta2 = random.Next(1, 11);

            string nuevaC = "";

            puntos = carta1 + carta2;
            Console.WriteLine("cartas iniciales: " + carta1 + ", " + carta2);
            Console.WriteLine("Acumulado: " + puntos);
         
            while (puntos <= 21 && nuevaC != "n")
            {

                Console.WriteLine("desea tomar otra carta? (s/n)");
                nuevaC = Console.ReadLine();

                if (nuevaC == "s")
                {
                    puntos += random.Next(1, 11);
                    Console.WriteLine("Acumulado: " + puntos);
                }
                            
             
            }
            if (puntos > 21) Console.WriteLine("has perdido. puntaje final: " + puntos);

            else if (puntos == 21) Console.WriteLine("has ganado. puntaje final: " + puntos);

            if (nuevaC == "n") Console.WriteLine("puntaje final: " + puntos);





        }
    }
}
