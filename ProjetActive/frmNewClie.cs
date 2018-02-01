using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetActive
{
    public partial class frmNewClie : ProjetActive.frmClie
    {
        public frmNewClie()
        {
            InitializeComponent();
            // crée un handler d'événement pour la prise de focus sur la textbox Numero   
            this.txtNumero.GotFocus += new EventHandler(txtNumero_GotFocus);
            lblErreur.Visible = false;
        }

        /// <summary>         
        /// remet à blanc le texte initial dès la prise de focus       
        /// </summary>   
        /// <param name="sender"></param> 
        /// <param name="e"></param>     
        private void txtNumero_GotFocus(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// Bouton Quitter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            DialogResult reponse;
            reponse = MessageBox.Show("Voulez-vous quitter la saisie d'un client?", "Nouveau client?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reponse == DialogResult.Yes)
            {
                this.Close();
            }
        }
        

        /// <summary>
        /// bouton OK: contrôler les données saisies dans le frmNewClie
        /// => instancier un objet Client et le référencer en collection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            
            
            
            // contrôle des saisies dans les textbox
            if (this.Controle())
            {
                if (this.Ajoute())
                {
                    this.DialogResult = DialogResult.OK;
                    // visualiser la saisie dans la datagridview
                    frmGrdDspClie frmG = new frmGrdDspClie();
                    frmG.ShowDialog();
                }
            }
        }

        /// <summary>
        /// fonction qui instancie un nouveau client
        /// + affecte ses propriétés avec interception d'erreurs évetntuelles de saisies
        /// </summary>
        /// <returns> Boolean : true = OK, false = erreur </returns>
        private Boolean Ajoute()
        {
            // créer un nouvel objet Client
            Client nouveauClient = new Client();

            // affecter les données de l'objet Client
            try
            {
                nouveauClient.IdClient = Int32.Parse(base.txtNumero.Text.Trim());
                nouveauClient.RaisonSociale = base.txtRaison.Text;
                
                if (rbtPrive.Checked)
                {
                    nouveauClient.TypeSociete = base.rbtPrive.Text;
                }
                else
                {
                    nouveauClient.TypeSociete = base.rbtPublic.Text;
                }
                nouveauClient.Activite = base.txtDomaine.Text;
                nouveauClient.Adresse = base.txtAdresse.Text;
                nouveauClient.CodePostal = base.txtCP.Text.Trim();
                nouveauClient.Ville = base.txtVille.Text;
                nouveauClient.Telephone = base.txtTelClient.Text;
                nouveauClient.CA = Double.Parse(base.txtCA.Text.Trim());
                nouveauClient.Effectif = Int32.Parse(base.txtEffectif.Text.Trim());

                if (rbtPrincipale.Checked)
                {
                    nouveauClient.Nature = base.rbtPrincipale.Text;
                }
                else
                {
                    if (rbtSecondaire.Checked)
                    {
                        nouveauClient.Nature = base.rbtSecondaire.Text;
                    }
                    else
                    {
                        nouveauClient.Nature = base.rbtAncienne.Text;
                    }
                }

                // impacter sur la BdD
                // création et renseignement Entity Client
                Client nouveauClientEF = new Client();
                nouveauClientEF.IdClient = nouveauClient.IdClient;
                nouveauClientEF.RaisonSociale = nouveauClient.RaisonSociale;
                nouveauClientEF.TypeSociete = nouveauClient.TypeSociete;
                nouveauClientEF.Activite = nouveauClient.Activite;
                nouveauClientEF.Adresse = nouveauClient.Adresse;
                nouveauClientEF.CodePostal = nouveauClient.CodePostal;
                nouveauClientEF.Ville = nouveauClient.Ville;
                nouveauClientEF.Telephone = nouveauClient.Telephone;
                nouveauClientEF.CA = nouveauClient.CA;
                nouveauClientEF.Effectif = nouveauClient.Effectif;
                nouveauClientEF.Nature = nouveauClient.Nature;

                // insertion en Dbcontext
                DonneesClient.Db.Client.Add(nouveauClientEF);
                // MAJ BdD
                DonneesClient.Db.SaveChanges();
                return true;
            }

            catch (Exception ex)
            {
                nouveauClient = null;
                MessageBox.Show("Erreur: \n" + ex.Message, "Client ajouté");
                return false;
              
            }
        }
        

        private void frmNewClie_Click(object sender, EventArgs e)
        {

        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            
        }


        /// <summary>
        /// fonction de contrôle de vraissemblance des saisies dans les textbox
        /// </summary>
        /// <returns> Boolean : true = OK, false = erreurs de saisie sur numéro client, code postal et téléphone </returns>
        private Boolean Controle()
        {
            // contrôler les bonnes saisies des textbox
            Boolean code = true;   // code de retour: OK

            if (!(Outils.EstEntier(this.txtNumero.Text)))
            {
                // chaîne non convertible
                code = false;
                MessageBox.Show("Le numéro du client n'est pas un entier valide.", "Erreur", MessageBoxButtons.OK);
            }


            if (!(Outils.EstEntier(this.txtCP.Text)))
            {
                // chaîne non convertible
                code = false;
                MessageBox.Show("Le code postal doit contenir 5 chiffres.", "Erreur", MessageBoxButtons.OK);
            }

            if (!(this.txtTelClient.TextLength==10))
            {
                // chaîne non convertible
                code = false;
                MessageBox.Show("Le numéro de téléphone doit être composé de 10 chiffres.", "Erreur", MessageBoxButtons.OK);
            }

            if (!(Outils.EstEntier(this.txtCA.Text)))
            {
                // chaîne non convertible
                code = false;
                MessageBox.Show("Le CA doit être composé uniquement de chiffres.", "Erreur", MessageBoxButtons.OK);
            }

            if (!(Outils.EstEntier(this.txtEffectif.Text)))
            {
                // chaîne non convertible
                code = false;
                MessageBox.Show("L'effectif doit être composé uniquement de chiffres.", "Erreur", MessageBoxButtons.OK);
            }


            // Afficher le message d'erreur si CA/employé > 1 million d'€uros
            if (txtCA.Text != "" && this.txtEffectif.Text != "")
            {
                if ((int.Parse(txtCA.Text) / int.Parse(txtEffectif.Text)) > 1000000)
                {
                    code = false;
                    lblErreur.Visible = false;
                    MessageBox.Show("Veuillez saisir des un CA et un effectif appréciables.", "Nouvelle saisie!", MessageBoxButtons.OK);
                }

            }
            return code;
        }
    
     
        /// <summary>
        /// fonction générique de contrôle qu'une chaîne reçue pourra se convertir en Int32
        /// </summary>
        /// <param name="s"></param>
        /// <returns> Boolean: true = OK, false = erreur</returns>
        private Boolean estEntier(String s)
        {
            Int32 i;     // indice de parcours dans la chaîne
            Char c;      // caractère courant
            Boolean code = true;    // code retour: OK

            // test longueur de chaîne reçue
            if (s.Length < 11 && s.Length > 0)
            {
                // vérification de tous les chiffres un à un 
                for (i = 0; i < s.Length; i++)
                {
                    c = s[i];     // extrait le rang du caractère
                    if (!(Char.IsDigit(c)))
                    {
                        code = false;
                    }
                }
            }
            else
            {
                code = false; // erreur détectée
            }
            return code;
        }


    }    

}
