using System;
using System.Collections.Generic;
using System.Text;

class Parcial {

    string[] names;
    double[] data;


    public Parcial(string[] _names, double[] _data) {
        data = new double[_data.Length];
        _data.CopyTo(data, 0);
        names = new string[_names.Length];
        _names.CopyTo(names, 0);
    }


    public int PrimerPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        int salida = 0;
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        double total = 0, promedio = 0;
        for (int i = 0; i < notas.Length; i++) {
            total += notas[i];
        }
        promedio = total / notas.Length;
        for (int i = 0; i < notas.Length; i++) {
            if (notas[i] >= promedio + 0.5) {
                salida++;
            }
        }

        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] SegundoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[5];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        double total = 0, promedio = 0;
        for (int i = 0; i < notas.Length; i++) {
            total += notas[i];
        }
        promedio = total / notas.Length;
        double[] distancias = new double[notas.Length];

        for (int i = 0; i < notas.Length; i++) {
            distancias[i] = Math.Abs(notas[i] - promedio);
        }

        for (int j = 0; j < notas.Length; j++) { // ORDENAMIENTO
            for (int i = 0; i < notas.Length - 1; i++) {
                if (distancias[i] < distancias[i + 1]) {

                    double tmp1 = distancias[i];
                    distancias[i] = distancias[i + 1];
                    distancias[i + 1] = tmp1;

                    string tmp2 = nombres[i];
                    nombres[i] = nombres[i + 1];
                    nombres[i + 1] = tmp2;
                }
            }
        }

        for (int i = 0; i < salida.Length; i++) {
            salida[i] = nombres[i];
        }


        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] TercerPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[0];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------




        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] CuartoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[0];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------



        //- Arriba de esta línea va su código --------
        return salida;
    }

    public List<string> TercerPuntoListas() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        List<string> salida = new List<string>();
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------

        for (int j = 0; j < notas.Length; j++) { // ORDENAMIENTO
            for (int i = 0; i < notas.Length-1; i++) {
                if (notas[i] > notas[i + 1]) {

                    double tmp1 = notas[i];
                    notas[i] = notas[i + 1];
                    notas[i + 1] = tmp1;

                    string tmp2 = nombres[i];
                    nombres[i] = nombres[i + 1];
                    nombres[i + 1] = tmp2;
                }
            }
        }

        double mediana = 0;
        if (notas.Length % 2 != 0) { // IMPAR
            mediana = notas[(int)(notas.Length / 2)];
        } else { // PAR
            mediana = (notas[(int)(notas.Length / 2)] + notas[(int)(notas.Length / 2)-1])/2;
        }

        for (int i = 0; i < notas.Length; i++) {
            if(notas[i] >= mediana + 0.5) {
                salida.Add(nombres[i]);
            }
        }

        //- Arriba de esta línea va su código --------
        return salida;
    }

    public List<string> CuartoPuntoListas() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        List<string> salida = new List<string>();
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        double total = 0, promedio = 0;
        for (int i = 0; i < notas.Length; i++) {
            total += notas[i];
        }
        promedio = total / notas.Length;

        for (int i = 0; i < nombres.Length; i++) {
            for (int j = 0; j < nombres[i].Length; j++) {
                if (nombres[i][j] == 'A' && notas[i] >= promedio) {
                    salida.Add(nombres[i]);
                    break;
                }
            }
        }
        //- Arriba de esta línea va su código --------
        return salida;
    }
}


