using System;


namespace SwitchCase1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese su salario mensual");
            double SalarioM = double.Parse(Console.ReadLine());

            Console.WriteLine("Tipo de contrato: 1.Dependiente, 2.Independiente");
            int Contrato = int.Parse(Console.ReadLine());

            double BaseCot = SalarioM * 0.4;

            if (BaseCot < 877803) BaseCot = 877803;

            double eps;
            double pension;
            double deducciones;
            
           
            switch ( Contrato)
            {
                case 1:
                    eps = BaseCot * 0.04;
                    pension = BaseCot * 0.04;
                    deducciones = eps + pension;
                    double SalarioR = SalarioM - deducciones;
                    double SalarioA = (SalarioR * 12) + SalarioM;
                    Console.WriteLine("Salario Real: " + SalarioR);
                    Console.WriteLine("Salario Anual: " + SalarioA);
                    break;
                case 2:
                    double arl;
                    eps = BaseCot * 0.125;
                    pension = BaseCot * 0.16;                 
                    Console.WriteLine("A que tipo de riesgo se expone del 1 al 5");
                    int risk = int.Parse(Console.ReadLine());

                    switch (risk)
                    {
                        case 1:
                            arl = BaseCot * (0.522 / 100);
                            deducciones = eps + pension + arl;
                            SalarioR = SalarioM - deducciones;
                            SalarioA = (SalarioR * 12);
                            Console.WriteLine("Salario Real: " + SalarioR);
                            Console.WriteLine("Salario Anual: " + SalarioA);
                            break;
                        case 2:
                            arl = BaseCot * (1.044 / 100);
                            deducciones = eps + pension + arl;
                            SalarioR = SalarioM - deducciones;
                            SalarioA = (SalarioR * 12);
                            Console.WriteLine("Salario Real: " + SalarioR);
                            Console.WriteLine("Salario Anual: " + SalarioA);
                            break;
                        case 3:
                            arl = BaseCot * (2.436 / 100);
                            deducciones = eps + pension + arl;
                            SalarioR = SalarioM - deducciones;
                            SalarioA = (SalarioR * 12);
                            Console.WriteLine("Salario Real: " + SalarioR);
                            Console.WriteLine("Salario Anual: " + SalarioA);
                            break;
                        case 4:
                            arl = BaseCot * (4.350 / 100);
                            deducciones = eps + pension + arl;
                            SalarioR = SalarioM - deducciones;
                            SalarioA = (SalarioR * 12);
                            Console.WriteLine("Salario Real: " + SalarioR);
                            Console.WriteLine("Salario Anual: " + SalarioA);
                            break;
                        case 5:
                            arl = BaseCot * (6.960 / 100);
                            deducciones = eps + pension + arl;
                            SalarioR = SalarioM - deducciones;
                            SalarioA = (SalarioR * 12);
                            Console.WriteLine("Salario Real: " + SalarioR);
                            Console.WriteLine("Salario Anual: " + SalarioA);
                            break;

                    }
              break;                                    
            }
        }
    }
}
