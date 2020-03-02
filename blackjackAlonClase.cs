using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ingrese el numero de jugadores, minimo 2, maximo 5");

            int n = int.Parse(Console.ReadLine()); ;
            //inicio validacion
            while (n < 2 && n > 5)
            {
                Console.WriteLine("ERROR, Los jugadores deben ser entre 2 y 5");
                n = int.Parse(Console.ReadLine());
            }

            string jugadorAnterior = null;
            string[] JugadorGanador = new string[n];
            string JugadorSegundo = null, temporalN = null;
            int puntuacion = 0, temporal = 0;
            int puntuacionSegundo = 0, segundisimo = 0;

            //inicio juego
            bool Eliminado = false;

            string DeseaContinuar = "no";
            int Carta1 = 0, Carta2 = 0, cartaNueva = 0;
            int[] valorMano = new int[n];
            Random Suerte = new Random();
            while (Eliminado == false)
            {

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Bienvenido, ingrese su nombre");
                    JugadorGanador[i] = Console.ReadLine();
                    Carta1 = Suerte.Next(1, 10);
                    Carta2 = Suerte.Next(1, 10);
                    valorMano[i] = Carta1 + Carta2;
                    Console.WriteLine("el valor de su mano es: " + valorMano[i]);
                    Console.WriteLine("Desea continuar? si/no");
                    DeseaContinuar = Console.ReadLine();
                    while (DeseaContinuar == "si")
                    {
                        cartaNueva = Suerte.Next(1, 10);
                        valorMano[i] += cartaNueva;
                        if (valorMano[i] > 21)
                        {
                            Eliminado = true;
                            DeseaContinuar = "no";
                            Console.Write("usted ha sido eliminado");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("el valor de su mano es: " + valorMano[i]);
                            Console.WriteLine("Desea continuar? si/no");
                            DeseaContinuar = Console.ReadLine();

                        }
                    }

                    if (puntuacion < valorMano[i] && valorMano[i] <= 21)
                    {
                        jugadorAnterior = JugadorGanador[i];
                        puntuacion = valorMano[i];
                        puntuacionSegundo = i;

                    }
                    Console.WriteLine("Gracias por participar, su puntuacion fue: " + valorMano[i]);
                }
                for (int i = 0; i < n; i++)
                {
                    if (i == puntuacionSegundo)
                    {
                        continue;
                    }
                    else
                    {
                        if (segundisimo < valorMano[i] && valorMano[i] < 21)
                        {
                            segundisimo = valorMano[i];
                            JugadorSegundo = JugadorGanador[i];
                        }
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n - 1; j++)
                    {
                        if (valorMano[j] > valorMano[j + 1])
                        {
                            temporal = valorMano[j];
                            valorMano[j] = valorMano[j + 1];
                            valorMano[j + 1] = temporal;
                            temporalN = JugadorGanador[j];
                            JugadorGanador[j] = JugadorGanador[j + 1];
                            JugadorGanador[j + 1] = temporalN;

                        }
                    }
                }
                     
                Eliminado = true;

            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(valorMano[i]);
                Console.WriteLine(JugadorGanador[i]);
            }
            Console.WriteLine("el ganador fue: " + jugadorAnterior);
            Console.WriteLine("el segundo fue: " + JugadorSegundo);
            
        }
    }
}