using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetActive
{
    public partial class frmClie : Form
    {
        public frmClie()
        {
            InitializeComponent();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            char s = e.KeyChar;
            if (!char.IsDigit(s) && s != 8)
            {
                e.Handled = true;
                MessageBox.Show("Ce champ ne prend que des valeurs numériques!");
            }
        }

        private void txtCP_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtTelClient_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEffectif_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelClient_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCA_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtEffectif_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
