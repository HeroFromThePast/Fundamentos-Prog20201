using System;

namespace simulacro
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();

            int dado1 = 0, dado2 = 0, puntos = 0, turnos = 0, dobles = 0;
            double mayor6 = 0;

            double porcentaje6 = 0;

            string tirar = "";

            while (puntos < 100 && tirar != "n")
            {
                Console.WriteLine("tirar dados? (s/n)");
                tirar = Console.ReadLine();

                if (tirar == "s")
                {
                    dado1 = random.Next(1, 7);
                    dado2 = random.Next(1, 7);
                    //dado1 = 1;
                    //dado2 = 1;
                    if (dado1 == 1 && dado2 == 1)
                    {
                        Console.WriteLine("Has pérdido");
                        tirar = "n";
                    }                  
                    else
                    {
                        Console.WriteLine(dado1);
                        Console.WriteLine(dado2);

                        puntos += dado1 + dado2;
                       
                        Console.WriteLine("puntos: " + puntos);
                        turnos += 1;
                        
                        if ((dado1+ dado2) > 6) mayor6 += 1;

                        if (dado1 == dado2) dobles += 1;

                        if (dobles == 3)
                        {
                            Console.WriteLine("Has ganado por 3 dobles!!");
                            tirar = "n";
                        } 
                    }

                }
                
            }
            porcentaje6 = (mayor6 / turnos) * 100;
            Console.WriteLine("Porcentaje de turnos donde el resultado fue superior a 6: " + porcentaje6);
            if (puntos >= 100) Console.WriteLine("Has ganado!!");                                             
        }
    }
}
