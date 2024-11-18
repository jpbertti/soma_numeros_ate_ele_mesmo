using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soma_numeros_ate_ele_mesmo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            txtNumero.Focus();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int valor;
            int soma = 0;
            valor = int.Parse(txtNumero.Text);
            

            int i = 1;
            while (i <= valor)
            {
                soma += i;
                i++;
            }
            lsbResultado.Items.Add("A soma de 1 até " + valor + " é " + soma);
        }
    }
}
