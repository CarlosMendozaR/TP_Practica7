using System;

namespace WindowsFormsApp1
{
    class Objetos
    {
        public byte partes;
        public float precio;
        public string numserie;

        public Objetos(byte partes, float precio, string numserie)
        {
            this.partes = partes;
            this.precio = precio;
            this.numserie = numserie;
        }
    }
}
