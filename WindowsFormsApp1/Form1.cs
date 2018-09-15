﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Matriz m1 = new Matriz();
        Matriz m2 = new Matriz();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearInventario_Click(object sender, EventArgs e)
        {
            string cadena1 = txtbPartes1.Text + "," + txtbPrecio1.Text + "," + txtbSerie1.Text + ";" + txtbPartes2.Text + "," + txtbPrecio2.Text + "," + txtbSerie2.Text + ";" + txtbPartes3.Text + "," + txtbPrecio3.Text + "," + txtbSerie3.Text;
            string cadena2 = txtbPartes4.Text + "," + txtbPrecio4.Text + "," + txtbSerie4.Text + ";" + txtbPartes5.Text + "," + txtbPrecio5.Text + "," + txtbSerie5.Text + ";" + txtbPartes6.Text + "," + txtbPrecio6.Text + "," + txtbSerie6.Text;
            m1.Leer(cadena1);
            m2.Leer(cadena2);
            label10.Text = "Inventario creado!";
        }

        private void btnTienda1_Click(object sender, EventArgs e)
        {
            lbTienda1.Text = m1.Precio().ToString();
        }

        private void btnTienda2_Click(object sender, EventArgs e)
        {
            lbTienda2.Text = m2.Precio().ToString();
        }

        private void btnPrecioTotal_Click(object sender, EventArgs e)
        {
            lbPrecioTotal.Text = (m1.Precio()+m2.Precio()).ToString();
        }

        private void btnTotalPiezas_Click(object sender, EventArgs e)
        {
            lbTotalPiezas.Text = (m1.Piezas() + m2.Piezas()).ToString();
        }
    }
}
