using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetActive
{
    public partial class frmUpdClie : ProjetActive.frmClie
    {

        /// <summary>
        /// la référence du client à modifier
        /// </summary>
        private Client leClient;

        /// <summary>
        /// constructeur qui mémorise le client à traiter
        /// </summary>
        public frmUpdClie(Client unClient)
        {
            //créer une référence d'objet client
            // pointant vers le client reçu en paramètre
            this.leClient = unClient;
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            DialogResult reponse;
            reponse = MessageBox.Show("Avez-vous enregistrer les modifications?", "Enregistrer?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (reponse == DialogResult.Yes)
            {
                MessageBox.Show("Modifications sauvegardées bien enregistrées.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Vous perdrez les données non enregistrées.");
                this.Close();
            }
        }
        

        /// <summary>         
        /// constructeur adapté : mémorise le stagiaire à traiter 
        /// </summary>         
        /// <param name="unClient">la reférence de l'objet Client à gérer dans ce form
        /// </param>
        private void frmUpdClie_Load(object sender, EventArgs e)
        {
            // afficher le client 
            this.afficheClient(this.leClient);
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


        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            // fermeture de la boite de dialogue avec sauvegarde des données modifiées    
            Int32 iClie = DonneesClient.ArrayStag.IndexOf(leClient);
            ((Client)DonneesClient.ArrayStag[iClie]).IdClient = Int32.Parse(this.txtNumero.Text.Trim());
            ((Client)DonneesClient.ArrayStag[iClie]).RaisonSociale = this.txtRaison.Text;
            if (rbtPrive.Checked)
            {
                ((Client)DonneesClient.ArrayStag[iClie]).TypeSociete = this.rbtPrive.Text;
            }
            else
            {
                ((Client)DonneesClient.ArrayStag[iClie]).TypeSociete = this.rbtPublic.Text;
            }
            ((Client)DonneesClient.ArrayStag[iClie]).TypeSociete = this.rbtPrive.Text;
            ((Client)DonneesClient.ArrayStag[iClie]).Activite = this.txtDomaine.Text;
            ((Client)DonneesClient.ArrayStag[iClie]).Adresse = this.txtAdresse.Text;
            ((Client)DonneesClient.ArrayStag[iClie]).CodePostal = this.txtCP.Text;
            ((Client)DonneesClient.ArrayStag[iClie]).Ville = this.txtVille.Text;
            ((Client)DonneesClient.ArrayStag[iClie]).CA = Int32.Parse(this.txtCA.Text.Trim());
            ((Client)DonneesClient.ArrayStag[iClie]).Effectif = Int32.Parse(this.txtEffectif.Text.Trim());

            if (rbtPrincipale.Checked)
            {
                ((Client)DonneesClient.ArrayStag[iClie]).Nature = this.rbtPrincipale.Text;
            }
            else
            {
                if (rbtSecondaire.Checked)
                {
                    ((Client)DonneesClient.ArrayStag[iClie]).Nature = this.rbtSecondaire.Text;
                }
                else
                {
                    ((Client)DonneesClient.ArrayStag[iClie]).Nature = this.rbtAncienne.Text;
                }
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
