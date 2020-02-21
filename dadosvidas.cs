using System;


namespace dadosXvidas
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int dado1 = 0, puntos = 0, dado2 = 0, vidas = 3, VidaMenos = 0, turnos = 1;
            string tirar = "";


            while (puntos < 100 && tirar != "n" && vidas >= 0)
            {
                Console.WriteLine("Tirar dado? (s/n)");
                tirar = Console.ReadLine();

                if (turnos < 3)
                {                  
                    dado1 = random.Next(1, 7);
                    puntos += dado1;
                    Console.WriteLine("dado: " + dado1);
                    Console.WriteLine("puntos: " + puntos);
                    Console.WriteLine("vidas: " + vidas);
                    VidaMenos++;
                    turnos++;
                }                                                       
                else if (turnos == 3) 
                {
                    Console.WriteLine("se lanzaran 2 dados");
                                     
                    dado1 = random.Next(1, 7);
                    dado2 = random.Next(1, 7);
                    puntos = puntos + dado1 + dado2;
                    Console.WriteLine("dado: " + dado1);
                    Console.WriteLine("dado: " + dado2);
                    Console.WriteLine("puntos: " + puntos);                
                    Console.WriteLine("vidas: " + vidas);
                    turnos = 0;
                    VidaMenos++;

                    if (dado1 == dado2)
                    {
                        Console.WriteLine("Has obtenido una vida!!");
                        vidas += 1;
                        Console.WriteLine("vidas: " + vidas);
                    }
                    

                }
                if (VidaMenos == 2)
                {
                    vidas -= 1;
                    VidaMenos = 0;
                    Console.WriteLine("Has perdido una vida");
                }


            }
           
        }
    }
}
