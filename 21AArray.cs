using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int puntos = 0, jugadores = 0, player = 0, puntosMax = 0;
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

            string[] nombres = new string[player];
            int[] puntajes = new int[player];



            for (int i = 0; i < nombres.Length ; i++)     
            { 
                Console.WriteLine("Nombre del jugador actual");
                nombres[i] = Console.ReadLine();

                Console.WriteLine("bienvenido al juego " + nombres[i]);

                puntajes[i] = carta1 + carta2;
                Console.WriteLine("cartas iniciales: " + carta1 + ", " + carta2);
                Console.WriteLine("Acumulado: " + puntajes[i]);


                while (puntos < 21 && nuevaC != "n")
                {

                    Console.WriteLine("desea tomar otra carta? (s/n)");
                    nuevaC = Console.ReadLine();

                    if (nuevaC == "s")
                    {
                        puntajes[i] += random.Next(1, 11);
                        Console.WriteLine("Acumulado: " + puntajes[i]);
                    }

                    if (puntajes[i] > 21)
                    {
                        Console.WriteLine("has perdido. puntaje final: " + puntajes[i]);
                        i++;
                       

                    }

                    else if (puntajes[i] == 21)
                    {
                        Ganador = nombres[i];
                        Console.WriteLine("has ganado. puntaje final: " + puntajes[i]);
                        i++;
                       

                    }

                    if (nuevaC == "n")
                    {
                        Console.WriteLine("puntaje final: " + puntajes[i]);                    
                        i++;
                        break;

                    }


                }



            }

            Console.WriteLine("Ganador: " + Ganador);
        }
    }
}
