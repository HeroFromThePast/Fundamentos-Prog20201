using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vruh
{
    class Program
    {
        static void Main(string[] args)
        {
            int Rep = 0;
            int wordIndex = 0; 


            Console.WriteLine("Escriba una frase");
            string frase = Console.ReadLine();

            frase = frase.ToUpper();
            string[] palabras = frase.Split(' ');

            Console.WriteLine("Escriba una palabra de la frase");
            string palabra = Console.ReadLine();
            palabra = palabra.ToUpper();

            int[] posiciones = new int[palabras.Length];

            for (int i = 0; i < palabras.Length; i++)
            {
                Console.WriteLine(palabras[i]);
                if (palabras[i] == palabra)
                {
                   
                    Rep += 1;
                    posiciones[wordIndex] = i;
                    wordIndex++;
                   
                }
               
            }
            for (int i = 0; i < palabras.Length; i++)
            {
                Console.WriteLine("la palabra está " + Rep + " veces en las posiciones " + posiciones[i]);
            }

           


        }
    }
}
