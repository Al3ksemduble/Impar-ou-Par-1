using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impar_ou_Par_1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumber.Text, out int numero))
            {
                MessageBox.Show("Por favor, digite um número válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (numero % 2 == 0)
            {
                lblResult.Text = "O Número é Par.";
            }
            else
            {
                lblResult.Text = "O Número é Impar.";
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtNumber.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
//1 textbox funcional para por o numero, 1 button de comando e 2 label(1 de instrução e outro nomeando a página)