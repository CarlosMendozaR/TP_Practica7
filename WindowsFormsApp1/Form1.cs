using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Matriz m1 = new Matriz();
        Matriz m2 = new Matriz();

        Objetos[,] vecinventarios = new Objetos[2,3];
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

            Objetos pieza1 = new Objetos((byte)m1.matriz[0, 0], m1.matriz[0, 1], m1.matriz[0, 2].ToString());
            Objetos pieza2 = new Objetos((byte)m1.matriz[1, 0], m1.matriz[1, 1], m1.matriz[1, 2].ToString());
            Objetos pieza3 = new Objetos((byte)m1.matriz[2, 0], m1.matriz[2, 1], m1.matriz[2, 2].ToString());
            Objetos pieza4 = new Objetos((byte)m2.matriz[0, 0], m2.matriz[0, 1], m2.matriz[0, 2].ToString());
            Objetos pieza5 = new Objetos((byte)m2.matriz[1, 0], m2.matriz[1, 1], m2.matriz[1, 2].ToString());
            Objetos pieza6 = new Objetos((byte)m2.matriz[2, 0], m2.matriz[2, 1], m2.matriz[2, 2].ToString());

            vecinventarios[0, 0] = pieza1;
            vecinventarios[0, 1] = pieza2;
            vecinventarios[0, 2] = pieza3;
            vecinventarios[1, 0] = pieza4;
            vecinventarios[1, 1] = pieza5;
            vecinventarios[1, 2] = pieza6;

            label10.Text = "Inventario creado!";

            if (rdbObjetos.Checked)
            {
                for (int a = 0; a < 2; a++)
                {
                    for (int b = 0; b < 3; b++)
                    {
                        label17.Text = label17.Text + vecinventarios[a, b].partes + "      " + vecinventarios[a, b].precio + "      " + vecinventarios[a, b].numserie + "\n";
                    }
                }
            }
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
