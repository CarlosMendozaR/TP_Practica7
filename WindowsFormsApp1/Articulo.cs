using System;


namespace WindowsFormsApp1
{
    class Articulo
    {
        private ushort numSerie;
        private float precio;
        private int numPartes;

        public Articulo()
        {

        }

        public Articulo(ushort numSerie, float precio, int numPartes)
        {
            this.numPartes = numPartes;
            this.numSerie = numSerie;
            this.precio = precio;
        }
    }
}
