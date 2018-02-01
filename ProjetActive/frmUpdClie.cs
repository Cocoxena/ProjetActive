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
            lblErreur.Visible = false;
            InitializeComponent();

        }

        /// <summary>
        /// Bouton Quitter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Bouton Enregistrer
        /// validation des modifications ==> affecter au client les nouvelles données saisies
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
                try
                {
                    this.leClient.IdClient = Int32.Parse(this.txtNumero.Text.Trim());
                    this.leClient.RaisonSociale = this.txtRaison.Text;
                    
                    if (rbtPrive.Checked)
                    {
                        this.rbtPrive.Text = this.leClient.TypeSociete;
                    }
                    else
                    {
                        this.rbtPublic.Text = this.leClient.TypeSociete;
                    }

                    this.leClient.Activite = this.txtDomaine.Text;
                    this.leClient.Adresse = this.txtAdresse.Text;
                    this.leClient.CodePostal = this.txtCP.Text;
                    this.leClient.Ville = this.txtVille.Text;
                    this.leClient.Telephone = this.txtTelClient.Text;
                    this.leClient.CA = Int32.Parse(this.txtCA.Text.Trim());
                    this.leClient.Effectif = Int32.Parse(this.txtEffectif.Text.Trim());

                    if (rbtPrincipale.Checked)
                    {
                        this.rbtPrincipale.Text = this.leClient.Nature;
                    }
                    else
                    {
                        if (rbtSecondaire.Checked)
                        {
                            this.rbtSecondaire.Text = this.leClient.Nature;

                        }
                        else
                        {
                            this.rbtAncienne.Text = this.leClient.Nature;
                        }
                    }

                // TODO liste de contacts 

                // impacter la BdD
                Client leClientEF = DonneesClient.Db.Client.Find(leClient.IdClient);
                // MAJ du client dans le Framework Entity
                leClientEF.IdClient = leClient.IdClient;
                leClientEF.RaisonSociale = leClient.RaisonSociale;
                leClientEF.TypeSociete = leClient.TypeSociete;
                leClientEF.Activite = leClient.Activite;
                leClientEF.Adresse = leClient.Adresse;
                leClientEF.CodePostal = leClient.CodePostal;
                leClientEF.Ville = leClient.Ville;
                leClientEF.Telephone = leClient.Telephone;
                leClientEF.CA = leClient.CA;
                leClientEF.Effectif = leClient.Effectif;
                leClientEF.Nature = leClient.Nature;

                // MAJ BdD
                DonneesClient.Db.SaveChanges();

                // Affichage message d'enregistrement 
                MessageBox.Show("Données sauvegardées", "Enregistrement");
                this.Close();
                
                // visualiser la saisie dans la datagridview
                frmGrdDspClie frmG = new frmGrdDspClie();
                frmG.ShowDialog();

                }

                catch (Exception ex)  // en cas d'erreur détectée
                {
                    MessageBox.Show(ex.Message, "Client modifié");
                }

                // fermer la fenêtre en enregistrant les modifications 


        }
    }
        
    }

