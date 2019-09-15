using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void BtnOperar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Convert.ToString(Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text));
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);

            return Calculadora.Operar(num1, num2, operador);
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            lblResultado.Text = "";
            cmbOperador.Text = "";
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConvertirABinaro_Click(object sender, EventArgs e)
        {
            if(lblResultado.Text=="")
            {
                lblResultado.Text = "";
            }
            else
            {
                Numero n2 = new Numero();
                lblResultado.Text = n2.DecimalBinario(lblResultado.Text);
            }
        }

        private void BtnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text == "")
            {
                lblResultado.Text = "";
            }
            else
            {
                Numero n1 = new Numero();
                lblResultado.Text = n1.BinarioDecimal(lblResultado.Text);
            }
        }
    }
}
