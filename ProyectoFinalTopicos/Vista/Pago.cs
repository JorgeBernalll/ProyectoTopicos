using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Pago : Form
    {
        public Pago()
        {
            InitializeComponent();            
        }

        private void btnTransaccion_Click(object sender, EventArgs e)
        {

            double efectivo = 0;
            double.TryParse(txtEfectivo.Text, out efectivo);

            double monto = Convert.ToDouble(txtMonto.Text);

            double adicion = monto * .02;
            if (cbxTarjeta.Checked == true)
            {
                monto = monto + adicion;
                if (efectivo < monto)
                {
                    MessageBox.Show("Fondos insuficientes");
                }
                else
                {                    
                    txtCambio.Text = (monto - efectivo).ToString("N2");
                    MessageBox.Show("Transaccion realizada correctamente, devuelva al cliente " +
                        "la cantidad de: $" + txtCambio.Text);
                }
            }
            else if(cbxTarjeta.Checked == false)
            {
                monto = monto - adicion; 
                double.TryParse(txtEfectivo.Text, out efectivo);               
                if (efectivo < monto)
                {
                    MessageBox.Show("Fondos insuficientes");
                }
                else
                {
                    txtCambio.Text = (monto - efectivo).ToString("N2");
                    MessageBox.Show("Transaccion realizada correctamente, devuelva al cliente " +
                        "la cantidad de: $" + txtCambio.Text);
                }
            }
        }

        private void cbxTarjeta_Click(object sender, EventArgs e)
        {
            double efectivo = 0;
            double.TryParse(txtEfectivo.Text, out efectivo);

            double monto = Convert.ToDouble(txtMonto.Text);

            double adicion = monto * .02;
            if (cbxTarjeta.Checked)
            {
                lblMetodo.Text = "Credito: ";
                txtMonto.Text = (monto = monto + adicion).ToString("N2");
            }
            else
            {
                lblMetodo.Text = "Efectivo";
                txtMonto.Text = (monto = monto - adicion).ToString("N2");
            }
        }

        private void txtEfectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }
    }
}