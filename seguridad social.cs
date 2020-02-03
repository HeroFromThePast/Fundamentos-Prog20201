using System;


namespace ConsoleApp6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("ingrese su salario mensual");
            double sm = double.Parse(Console.ReadLine());
            Console.WriteLine("Que tipo de contrato tiene: 1.Dependiente 2.independiente");
            double Cont = double.Parse(Console.ReadLine());
            double SMLMV = 877803;

            double Bcot = sm * 0.4;

            double SMR; //salario real mensual 
            double SAR; //salario anual real

            double pen;
            double eps;
            double arl;

            if (Bcot <= SMLMV && Cont == 2)
            {
                Console.WriteLine("ingrese del 1 al 5 a a que tanto riesgo esta expuesto");
                int risk = int.Parse(Console.ReadLine());

                if (risk == 1)
                {
                    pen = SMLMV * 0.16;
                    eps = SMLMV * 0.125;
                    arl = SMLMV * 0.00522;

                    SMR = sm - pen - eps - arl;
                    SAR = (SMR * 12) + sm;

                    Console.WriteLine("su salario real mensual es: " + SMR);
                    Console.WriteLine("su salario anual: " + SAR);
                }
                else if (risk == 2)
                {
                    pen = SMLMV * 0.16;
                    eps = SMLMV * 0.125;
                    arl = SMLMV * 0.01044;

                    SMR = sm - pen - eps - arl;
                    SAR = (SMR * 12) + sm;

                    Console.WriteLine("su salario real mensual es: " + SMR);
                    Console.WriteLine("su salario anual: " + SAR);
                }
                else if (risk == 3)
                {
                    pen = SMLMV * 0.16;
                    eps = SMLMV * 0.125;
                    arl = SMLMV * 0.02436;

                    SMR = sm - pen - eps - arl;
                    SAR = (SMR * 12) + sm;

                    Console.WriteLine("su salario real mensual es: " + SMR);
                    Console.WriteLine("su salario anual: " + SAR);
                }
                else if (risk == 4)
                {
                    pen = SMLMV * 0.16;
                    eps = SMLMV * 0.125;
                    arl = SMLMV * 0.04350;

                    SMR = sm - pen - eps - arl;
                    SAR = (SMR * 12) + sm;

                    Console.WriteLine("su salario real mensual es: " + SMR);
                    Console.WriteLine("su salario anual: " + SAR);
                }
                else
                {
                    pen = SMLMV * 0.16;
                    eps = SMLMV * 0.125;
                    arl = SMLMV * 0.06960;

                    SMR = sm - pen - eps - arl;
                    SAR = (SMR * 12) + sm;

                    Console.WriteLine("su salario real mensual es: " + SMR);
                    Console.WriteLine("su salario anual: " + SAR);
                }
            }
            //-----------------------------------------------------------------------------------
            else if (Bcot > SMLMV && Cont == 2)
            {
                Console.WriteLine("ingrese del 1 al 5 a a que tanto riesgo esta expuesto");
                int risk = int.Parse(Console.ReadLine());

                if (risk == 1)
                {
                    pen = Bcot * 0.16;
                    eps = Bcot * 0.125;
                    arl = Bcot * 0.00522;

                    SMR = sm - pen - eps - arl;
                    SAR = (SMR * 12);

                    Console.WriteLine("su salario real mensual es: " + SMR);
                    Console.WriteLine("su salario anual: " + SAR);
                }
                else if (risk == 2)
                {
                    pen = Bcot * 0.16;
                    eps = Bcot * 0.125;
                    arl = Bcot * 0.01044;

                    SMR = sm - pen - eps - arl;
                    SAR = (SMR * 12);

                    Console.WriteLine("su salario real mensual es: " + SMR);
                    Console.WriteLine("su salario anual: " + SAR);
                }
                else if (risk == 3)
                {
                    pen = Bcot * 0.16;
                    eps = Bcot * 0.125;
                    arl = Bcot * 0.02436;

                    SMR = sm - pen - eps - arl;
                    SAR = (SMR * 12);

                    Console.WriteLine("su salario real mensual es: " + SMR);
                    Console.WriteLine("su salario anual: " + SAR);
                }
                else if (risk == 4)
                {
                    pen = Bcot * 0.16;
                    eps = Bcot * 0.125;
                    arl = Bcot * 0.04350;

                    SMR = sm - pen - eps - arl;
                    SAR = (SMR * 12);

                    Console.WriteLine("su salario real mensual es: " + SMR);
                    Console.WriteLine("su salario anual: " + SAR);
                }
                else
                {
                    pen = Bcot * 0.16;
                    eps = Bcot * 0.125;
                    arl = Bcot * 0.06960;

                    SMR = sm - pen - eps - arl;
                    SAR = (SMR * 12);

                    Console.WriteLine("su salario real mensual es: " + SMR);
                    Console.WriteLine("su salario anual: " + SAR);
                }
            }
            else if (Bcot <= SMLMV && Cont == 1)
            {
                pen = SMLMV * 0.4;
                eps = SMLMV * 0.4;
                arl = 0;

                SMR = sm - pen - eps - arl;
                SAR = (SMR * 12) + sm;

                Console.WriteLine("su salario real mensual es: " + SMR);
                Console.WriteLine("su salario anual: " + SAR);
            }
            else if (Bcot > SMLMV && Cont == 1)
            {
                pen = Bcot * 0.04;
                eps = Bcot * 0.04;
                arl = 0;

                SMR = sm - pen - eps - arl;
                SAR = (SMR * 12) + sm;

                Console.WriteLine("su salario real mensual es: " + SMR);
                Console.WriteLine("su salario anual: " + SAR);
            }
            else return;

                

        }
    }
}
