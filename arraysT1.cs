using System;


namespace arrays1
{
    class Program
    {
        static void Main()
        {
            double[] CoordsX = { 0, 2, 3, 7 };
            double[] CoordsY = { 0, 1, 5, 6 };
            double mAnt = 0, maxD = 0, D = 0;

            for (int i = 1; i <= 3; i++)
            {
                mAnt = (CoordsY[i] - CoordsY[0]) / (CoordsX[i] - CoordsX[0]);
                Console.WriteLine("pendiente desde el punto (0,0) con: " + CoordsX[i] + "," + CoordsY[i] + " = " + mAnt);
            }
            Console.WriteLine("___________________________________________________________");
            for (int i = 0; i <= 3; i++)
            {
                mAnt = (CoordsY[i] - CoordsY[1]) / (CoordsX[i] - CoordsX[1]);
                Console.WriteLine("pendiente desde el punto (2,1) con: " + CoordsX[i] + "," + CoordsY[i] + " = " + mAnt);
            }
            Console.WriteLine("___________________________________________________________");
            for (int i = 0; i <= 3; i++)
            {
                mAnt = (CoordsY[i] - CoordsY[2]) / (CoordsX[i] - CoordsX[2]);
                Console.WriteLine("pendiente desde el punto (3,5) con: " + CoordsX[i] + "," + CoordsY[i] + " = " + mAnt);
            }
            Console.WriteLine("___________________________________________________________");
            for (int i = 0; i <= 3; i++)
            {
                mAnt = (CoordsY[i] - CoordsY[3]) / (CoordsX[i] - CoordsX[3]);
                Console.WriteLine("pendiente desde el punto (7,6) con: " + CoordsX[i] + "," + CoordsY[i] + " = " + mAnt);
            }
            Console.WriteLine("___________________________________________________________");

            Console.WriteLine("distancias");

            for (int i = 1; i <= 3; i++)
            {

                D = Math.Sqrt((CoordsX[0] - CoordsX[i]) * (CoordsX[0] - CoordsX[i]) + (CoordsY[0] - CoordsY[i]) * (CoordsY[0] - CoordsY[i]));
                Console.WriteLine("Distancia de (0,0) a " + CoordsX[i] + "," + CoordsY[i] + " = " + D);
                if (D > maxD) maxD = D;

            }

            Console.WriteLine("___________________________________________________________");

            for (int i = 0; i <= 3; i++)
            {

                D = Math.Sqrt((CoordsX[1] - CoordsX[i]) * (CoordsX[1] - CoordsX[i]) + (CoordsY[1] - CoordsY[i]) * (CoordsY[1] - CoordsY[i]));
                Console.WriteLine("Distancia de (2,1) a " + CoordsX[i] + "," + CoordsY[i] + " = " + D);
                if (D > maxD) maxD = D;

            }

            Console.WriteLine("___________________________________________________________");

            for (int i = 0; i <= 3; i++)
            {

                D = Math.Sqrt((CoordsX[2] - CoordsX[i]) * (CoordsX[2] - CoordsX[i]) + (CoordsY[2] - CoordsY[i]) * (CoordsY[2] - CoordsY[i]));
                Console.WriteLine("Distancia de (3,5) a " + CoordsX[i] + "," + CoordsY[i] + " = " + D);
                if (D > maxD) maxD = D;

            }

            Console.WriteLine("___________________________________________________________");

            for (int i = 0; i <= 3; i++)
            {

                D = Math.Sqrt((CoordsX[3] - CoordsX[i]) * (CoordsX[3] - CoordsX[i]) + (CoordsY[3] - CoordsY[i]) * (CoordsY[3] - CoordsY[i]));
                Console.WriteLine("Distancia de (7,6) a " + CoordsX[i] + "," + CoordsY[i] + " = " + D);
                if (D > maxD) maxD = D;

            }

            Console.WriteLine("___________________________________________________________");

            Console.WriteLine("distancia mayor: " + maxD);
        }
    }
}
