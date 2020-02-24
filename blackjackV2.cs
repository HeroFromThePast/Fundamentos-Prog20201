using System;


namespace blackjack2
{
    class Program
    {
        static void Main()
        {


            int puntos = 0, jugadores = 0, player = 0,  puntosMax = 0;
            string Ganador = "", jugador = "";
           

            Random random = new Random();
            int carta1 = random.Next(1, 11);
            int carta2 = random.Next(1, 11);

            string nuevaC = "";

            Console.WriteLine("Ingrese el numero de jugadores");
            jugadores = int.Parse(Console.ReadLine());

            while (jugadores < 2 || jugadores > 5)
            {             
                    Console.WriteLine("Numero de jugadores no válido");
                    jugadores = int.Parse(Console.ReadLine());                           
            }
            if (jugadores < 5 && jugadores > 2)
            {
                player = jugadores;
            }

           
   
           while (player > 0)
           {
                Console.WriteLine("Nombre del jugador actual");
                jugador = Console.ReadLine();

                Console.WriteLine("bienvenido al juego " + jugador);

                puntos = carta1 + carta2;
                Console.WriteLine("cartas iniciales: " + carta1 + ", " + carta2);
                Console.WriteLine("Acumulado: " + puntos);


                while (puntos < 21 && nuevaC != "n")
                { 

                        Console.WriteLine("desea tomar otra carta? (s/n)");
                        nuevaC = Console.ReadLine();

                        if (nuevaC == "s")
                        {
                            puntos += random.Next(1, 11);
                            Console.WriteLine("Acumulado: " + puntos);
                        }

                        if (puntos > 21)
                        {
                            Console.WriteLine("has perdido. puntaje final: " + puntos);
                            player -= 1;
                    
                        }

                        else if (puntos == 21)
                        {
                            Ganador = jugador;
                            Console.WriteLine("has ganado. puntaje final: " + puntos);
                            player -= 1;

                        }

                        if (nuevaC == "n")
                        {
                            Console.WriteLine("puntaje final: " + puntos);
                            player -= 1;
                            break;

                        }


                }
                
               

           }

                Console.WriteLine("Ganador: " + Ganador);
           
        }
    }
}
