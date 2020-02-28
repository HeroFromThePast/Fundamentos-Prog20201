using System;

namespace arraysCC
{
    class Program
    {
        static void Main()
        {
            int edadMax = 0, edadMin = 100, totalEdad = 0, indicePromedio = 0;
            double ValorPromedio = 0, desviacion = 0, DesActual = 0, SumDesviacion = 0, desvMin = 1000, desvReal = 0;
            double edadAct = 0;
            string mayor = null, menor = null;

            Console.WriteLine("Ingrese la cantidad de datos totales");
            int datos = int.Parse(Console.ReadLine());
            string[] nombres = new string[datos];
            int[] edades = new int[datos];

            for (int i = 0; i < edades.Length; i++)
            {
                Console.WriteLine("Escriba el nombre y la edad");

                nombres[i] = Console.ReadLine();
                edades[i] = int.Parse(Console.ReadLine());
                totalEdad += edades[i];
                edadAct = edades[i];


                if (edadAct < edadMin)
                {
                    edadMin = edades[i];
                    menor = nombres[i];
                }

                if (edadAct > edadMax)
                {
                    edadMax = edades[i];
                    mayor = nombres[i];
                }
            }

            Console.WriteLine("El mayor es " + mayor + " y su edad es " + edadMax);
            Console.WriteLine("El menor es " + menor + " y su edad es " + edadMin);

            //promedio
            ValorPromedio = totalEdad / edades.Length;

            for (int j = 0; j < edades.Length; j++)
            {
                desviacion = ((edades[j] - ValorPromedio) * (edades[j] - ValorPromedio));
                SumDesviacion += desviacion;
                desvReal = Math.Sqrt(SumDesviacion / edades.Length);
                DesActual = desviacion;
                if (DesActual < desvMin)
                {
                    desvMin = DesActual;
                    indicePromedio = j;
                }
            }

            Console.WriteLine("Promedio = " + ValorPromedio + "Desviacion estandar = " + desvReal           );
            Console.WriteLine("La persona más cercana al promedio es = " +  );









        }
    }
}
