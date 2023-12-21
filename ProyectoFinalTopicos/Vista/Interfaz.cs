using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculosVentas;

namespace Vista
{
    public partial class Interfaz : Form
    {
        public Interfaz()
        {
            InitializeComponent();
        }

        public List<double> listaCostos = new List<double>();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if ((txtCosto.Text == string.Empty) || (txtProducto.Text == string.Empty))
            {
                MessageBox.Show("Tiene que llenar los 2 campos");
            }
            else
            {
                lbxProductos.Items.Add(txtProducto.Text);
                lbxCostos.Items.Add(txtCosto.Text);
                listaCostos.Add(double.Parse(txtCosto.Text));


                double sub =
                  Calculos.
                  Subtotal(listaCostos);
                txtSubtotal.Text = (sub).ToString("N2");

                double iva =
                    Calculos.
                    IVA(sub);
                txtIva.Text = (iva).ToString("N2");

                double total =
                    Calculos.
                    Total(iva, sub);
                txtTotal.Text = (total).ToString("N2");

                txtProducto.Clear();
                txtCosto.Clear();
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            var formulario = new Pago();
            formulario.txtMonto.Text = txtTotal.Text;
            formulario.Show();
        }

        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }
    }
}
