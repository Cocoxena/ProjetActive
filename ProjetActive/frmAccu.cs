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
    public partial class frmAccu : Form
    {
        public frmAccu()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vous allez quitter Active?", "Quitter");
            Application.Exit();
        }

        private void frmAccu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult reponse;
            reponse = MessageBox.Show("Voulez-vous vraiment quitter Active?", "Quitter l'application?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (reponse == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void frmAccu_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            frmLogIn frmPrinc;
            frmPrinc = new frmLogIn();
            frmPrinc.MdiParent = this;
            frmPrinc.Show();
        }

        /// <summary>
        /// menu Gestion Commerciale/Fichier Client/Consulter
        /// ==> ouvrir le frmGrdDspClie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void consulterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrdDspClie frm = new frmGrdDspClie();
            frm.Show();
        }


        /// <summary>
        /// menu Gestion Commerciale/Fichier Client/Ajouter un Client
        /// ==> ouvrir le frmNewClie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nouveauClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewClie frmN = new frmNewClie();
            frmN.Show();
        }


        /// <summary>
        /// menu Gestion Commerciale/Fichier Client/Modifier un Client
        /// ==> ouvrir le frmUpdClie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modifierUneFicheClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrdDspClie frm = new frmGrdDspClie();
            frm.Show();
            MessageBox.Show("Veuillez sélectionner un client.", "Modification");
        }


        /// <summary>
        /// menu Gestion Commerciale/Fichier Client/Supprimer un Client
        /// ==> ouvrir le frmDelClie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void supprimerUnClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrdDspClie frm = new frmGrdDspClie();
            frm.Show();
            MessageBox.Show("Veuillez sélectionner un client.","Suppression");
        }
    }
}
