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
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void frmLogIn_Load(object sender, EventArgs e)
        {

        }

        private void frmLogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult reponse;
            reponse = MessageBox.Show("Voulez-vous vraiment quitter Active?", "Quitter l'application?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (reponse == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void txtMotdePasse_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtIdentifiant_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

    }
}
