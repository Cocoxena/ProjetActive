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
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            DialogResult reponse;
            reponse = MessageBox.Show("Voulez-vous ajouter un autre client?", "Autre client?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reponse == DialogResult.No)
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
            // créer un nouvel objet Client
            Client nouveauClient = new Client();
            /*try
            {*/
                // affecter les données de l'objet Client
                nouveauClient.IdClient = Int32.Parse(base.txtNumero.Text.Trim());
                nouveauClient.RaisonSociale = base.txtRaison.Text;
                nouveauClient.TypeSociete = base.rbtPrive.Text;
                if (rbtPrive.Checked)
                {
                    nouveauClient.TypeSociete = base.rbtPrive.Text;
                }
                else nouveauClient.TypeSociete = base.rbtPublic.Text;
                nouveauClient.Activite = base.txtDomaine.Text;
                nouveauClient.Adresse = base.txtAdresse.Text;
                nouveauClient.CodePostal = base.txtCP.Text.Trim();
                nouveauClient.Ville = base.txtVille.Text;
                nouveauClient.Telephone = base.txtTelClient.Text;
                nouveauClient.CA = Decimal.Parse(base.txtCA.Text.Trim());
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
            
                //ajouter la référence d'objet Client dans la collection
                DonneesClient.ArrayStag.Add(nouveauClient);

            // visualiser la saisie dans la datagridview
            
            frmGrdDspClie frmG = new frmGrdDspClie();
            frmG.ShowDialog();

            // incrémenter compteur de clients
            /*
             * Client.Nstag += 1;
               */

            /*
            }
            catch (Exception ex)
            {
                nouveauClient = null;
                MessageBox.Show("Erreur: \n" + ex.Message, "Vous souhaitez ajouter un Client?");
            }*/

        }
    }
}
