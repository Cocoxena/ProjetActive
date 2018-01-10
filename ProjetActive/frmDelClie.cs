using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetActive
{
    public partial class frmDelClie : ProjetActive.frmClie
    {

        /// <summary>
        /// la référence du client à modifier
        /// </summary>
        private Client leClient;

        /// <summary>
        /// constructeur qui mémorise le client à traiter
        /// </summary>
        public frmDelClie(Client unClient)
        {
            //créer une référence d'objet client
            // pointant vers le client reçu en paramètre
            this.leClient = unClient;
            InitializeComponent();

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

        }
    }
}
