using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetActive
{
    public partial class frmNewInte : ProjetActive.frmInte
    {
        public frmNewInte()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNewInte_Load(object sender, EventArgs e)
        {

        }
    }
}
