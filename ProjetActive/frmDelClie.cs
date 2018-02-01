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


        private void frmDelClie_Load(object sender, EventArgs e)
        {
            // afficher le client 
            this.afficheClient(this.leClient);
        }


        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult reponse;
            reponse = MessageBox.Show("Voulez-vous vraiment supprimer cette fiche client, car tous les contacts associés seront supprimés également?", "Supprimer?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); ;

            if (reponse == DialogResult.Yes)
            {
                // supprimer le client de la liste
                DonneesClient.Db.Client.Remove(leClient);

                // impacter dans la BdD
                DonneesClient.Db.SaveChanges();
                this.DialogResult = DialogResult.OK;
            }
                       
        }
        
        /// <summary>        
        /// cette procédure affiche en textbox les données d'un client       
        /// </summary>         
        /// <param name="unClient">la référence du client à afficher
        /// </param>     
        private void afficheClient(Client unClient)
        {
            // affecter les textbox             
            this.txtNumero.Text = unClient.IdClient.ToString();
            this.txtRaison.Text = unClient.RaisonSociale;

            if (rbtPrive.Checked)
            {
                this.rbtPrive.Text = unClient.TypeSociete;
            }
            else
            {
                this.rbtPublic.Text = unClient.TypeSociete;
            }

            this.txtDomaine.Text = unClient.Activite;
            this.txtAdresse.Text = unClient.Adresse;
            this.txtCP.Text = unClient.CodePostal;
            this.txtVille.Text = unClient.Ville;
            this.txtCA.Text = unClient.CA.ToString();
            this.txtEffectif.Text = unClient.Effectif.ToString();

            if (rbtPrincipale.Checked)
            {
                this.rbtPrincipale.Text = unClient.Nature;
            }
            else
            {
                if (rbtSecondaire.Checked)
                {
                    this.rbtSecondaire.Text = unClient.Nature;

                }
                else
                {
                    this.rbtAncienne.Text = unClient.Nature;
                }
            }
        }
    }
}
