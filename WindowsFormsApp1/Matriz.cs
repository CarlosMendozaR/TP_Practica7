using System;

namespace WindowsFormsApp1
{
    class Matriz
    {
        private float[,] matriz = new float[3, 3];

        public Matriz()
        {

        }

        public void Leer (String cadena)
        {
            string[] columnas = cadena.Split(',');
            string[] renglones = cadena.Split(';');
            
            for(int i = 0; i<3; i++)
            {
                columnas = renglones[i].Split(',');
                for (int j = 0; j < 3; j++)
                {
                    matriz[i, j] = float.Parse(columnas[j]);
                }
            }
        }

        public int Piezas ()
        {
            int piezas = (int)(matriz[0, 0] + matriz[1, 0] + matriz[2, 0]);
            return piezas;
        }

        public float Precio()
        {
            float precio = matriz[0, 1] + matriz[1, 1] + matriz[2, 1];
            return precio;
        }
    }
}
