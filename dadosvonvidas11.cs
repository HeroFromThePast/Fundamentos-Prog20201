using System;


namespace Dadoconvidas
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int vidas = 0, puntos = 0, dado = 0, dadosEsp = 2, CondUno = 0;
            string DadoEsp = "", Tirar = "";
            bool uno = false, seis = false;

            while (puntos < 100 && Tirar != "n" && vidas >= 0)
            {
                Console.WriteLine("Tirar el dado? (s/n)");
                Tirar = Console.ReadLine();
                if (Tirar != "n" && dadosEsp >= 0)
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
                        dado = random.Next(1, 7);
                       // dado = 6;
                        Console.WriteLine("dado: " + dado);
                        puntos += dado;
                        Console.WriteLine("puntos: " + puntos);

                    }

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


                if (dado == 6 && vidas < 3) seis = true;
                if (seis && dado != 6) seis = false;
                else if (seis && dado == 6 && vidas <= 3)
                {
                    vidas += 1;
                    Console.WriteLine("Ganaste una vida");
                }



            }
            if (puntos >= 100) Console.WriteLine("has ganado");
               
                








        }

    }
}

