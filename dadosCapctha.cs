using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main()
        {
            
            int x, y, sumaCorrecta = 0, intentos = 3, Respuesta = 0;

            Random random = new Random();
            int vidas = 0, puntos = 0, dado = 0, dadosEsp = 2, CondUno = 0, seis = 0;
            string DadoEsp = "", Tirar = "";
            bool uno = false;

            while (intentos > 0)
            {
                x = random.Next(1, 11);
                y = random.Next(1, 11);

                sumaCorrecta = x + y;
                Console.WriteLine(+x + " + " + y);
                Console.WriteLine("Intentos restantes: " + intentos);
                Console.WriteLine("Ingrese el resultado de la suma para continuar");
                Respuesta = int.Parse(Console.ReadLine());
                while (Respuesta != sumaCorrecta)
                {
                    Console.WriteLine("Debe realizar la suma correcta");
                    intentos--;
                    break;
                }
                if (Respuesta == sumaCorrecta)
                {
                    Console.WriteLine("Puede continuar");
                    break;
                }
                if (intentos == 0)
                {
                    Console.WriteLine("Se ha quedado sin intentos, vuelva más tarde");
                    break;
                }

            }


            if (Respuesta == sumaCorrecta)
            {
                while (puntos < 100 && Tirar != "n" && vidas >= 0)
                {
                    Console.WriteLine("Tirar el dado? (s/n)");
                    Tirar = Console.ReadLine();
                    if (dadosEsp >= 0)
                    {
                        Console.WriteLine("Usar dado especial? (s/n)");
                        DadoEsp = Console.ReadLine();
                        if (DadoEsp != "n")
                        {
                            dado = random.Next(1, 13);
                            dadosEsp -= 1;
                            Console.WriteLine("dado: " + dado);
                            puntos += dado;
                            Console.WriteLine("puntos: " + puntos);
                        }
                        else
                        {
                            //dado = random.Next(1, 7);
                            dado = 6;
                            //dado = 1;
                            Console.WriteLine("dado: " + dado);
                            puntos += dado;
                            Console.WriteLine("puntos: " + puntos);
                        }
                    }

                    else
                    {
                        dado = random.Next(1, 7);
                        //dado = 6;
                        Console.WriteLine("dado: " + dado);
                        puntos += dado;
                        Console.WriteLine("puntos: " + puntos);

                    }

                    if (dado == 1)
                    {
                        //uno = true;
                        CondUno += 1;
                    }
                    if (CondUno == 2 && dado == 1)
                    {
                        vidas -= 1;
                        Console.WriteLine("perdiste una vida. Vidas: " + vidas);
                        CondUno = 0;
                    }

                    if (dado == 6) seis += 1;
                    if (seis % 2 == 0 && dado == 6 && vidas <= 3)
                    {
                        Console.WriteLine("has ganado una vida");
                        vidas += 1;
                        Console.WriteLine("vidas: " + vidas);
                    }
                    else if (seis == 2 && dado != 6) seis = 0;

                }
            }

              
            if (puntos >= 100) Console.WriteLine("has ganado. puntos: " + puntos);
            if (vidas < 0) Console.WriteLine("has perdido. puntos: " + puntos);
            if (Tirar == "n") Console.WriteLine("gracias por jugar. puntos: " + puntos);












        }
    }
}
