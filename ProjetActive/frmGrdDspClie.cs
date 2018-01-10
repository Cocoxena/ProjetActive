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
    public partial class frmGrdDspClie : Form
    {
        public frmGrdDspClie()
        {
            InitializeComponent();
            listeClients();
        }

        private void lblAffichage_Click(object sender, EventArgs e)
        {

        }

        private void btnTous_Click(object sender, EventArgs e)
        {
            this.txtNom.Text = null;
            this.txtDomaine.Text = null;
            this.txtMotCle.Text = null;
            ((DataView)(this.grdClie.DataSource)).RowFilter = null;
        }

        /// <summary>        
        /// bouton Ajouter : instancier un form pour saisir un nouveau client frmNewClie
        /// puis réafficher la datagridview 
        /// </summary>         
        /// <param name="sender"></param>     
        /// <param name="e"></param> 
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            this.Hide();
            // instancie le frmNewClie pour la saisie d'un nouveau client et l'affiche en modal
            frmNewClie frmNew = new frmNewClie();
            // sortie de la saisie par OK
            if (frmNew.ShowDialog() == DialogResult.OK)
            {
                //régénère l'affichage de la datagridview 
                listeClients();
            }
        }






        /// <summary>         
        /// rétablit la source de données de la dataGridView  
        /// et rafraîchit son affichage         
        /// </summary> 
        private void listeClients()
        {
            // datatable: pour recopier les clients stockés en collection
            // à relier au datagridview pour personnaliser l'affichage
            DataTable dt = new DataTable();
            DataRow dr;    // ligne de la datatable             
            Int32 i;       // var de boucle 

            // ajout à la datatable de 3 colonnes personnalisées 
            dt.Columns.Add(new DataColumn("Numéro", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("Nom", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Type", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Domaine activité", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Adresse", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Code Postal", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Ville", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Téléphone", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Chiffres Affaires", typeof(System.Decimal)));
            dt.Columns.Add(new DataColumn("Effectif", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("Nature", typeof(System.String)));

            // boucle remplissage de la DataTable à partir de la collection  
            for (i = 0; i < DonneesClient.ArrayStag.Count; i++)
            {
                // instanciation DataRow (=ligne de DataTable)                 
                dr = dt.NewRow();
                // affectation des 11 colonnes                
                // la collection voit les éléments comme des ‘Object’                  
                // ==>'caster' en Client pour en voir les attributs                
                dr[0] = ((Client)(DonneesClient.ArrayStag[i])).IdClient;
                dr[1] = ((Client)(DonneesClient.ArrayStag[i])).RaisonSociale;
                dr[2] = ((Client)(DonneesClient.ArrayStag[i])).TypeSociete;
                dr[3] = ((Client)(DonneesClient.ArrayStag[i])).Activite;
                dr[4] = ((Client)(DonneesClient.ArrayStag[i])).Adresse;
                dr[5] = ((Client)(DonneesClient.ArrayStag[i])).CodePostal;
                dr[6] = ((Client)(DonneesClient.ArrayStag[i])).Ville;
                dr[7] = ((Client)(DonneesClient.ArrayStag[i])).Telephone;
                dr[8] = ((Client)(DonneesClient.ArrayStag[i])).CA;
                dr[9] = ((Client)(DonneesClient.ArrayStag[i])).Effectif;
                dr[10] = ((Client)(DonneesClient.ArrayStag[i])).Nature;

                // ajout de la ligne à la Datatable                 
                dt.Rows.Add(dr);
            }
            // fin de boucle       

            // déterminer l'origine des données à afficher en DataGridView  
            // on pourrait donner la DataTable, on choisit la vue associée à la DataTable    
            // pour pouvoir effectuer des sélections directes
            this.grdClie.DataSource = dt.DefaultView;
            // refraîchir l'affichage (même pas utile…)             
            this.grdClie.Refresh();
            dt = null; // pas vraiment utile non plus…             
            dr = null;
        }






        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>         
        /// Double-clic sur le datagridview :  
        /// ouvrir la feuille détail en y affichant       
        /// le client correspondant à la ligne double-cliquée        
        /// </summary>         
        /// <param name="sender"></param>
        /// <param name="e"></param>   
        private void frmGrdDspClie_DoubleClick(object sender, EventArgs e)
        {
            // ouvrir la feuille détail en y affichant              
            // le client correspondant à la ligne double-cliquée 

            Int32 iClie;        // rang du client dans la liste 

            // récupérer indice du client cliqué en DataGridView             
            iClie = this.grdClie.CurrentRow.Index;
            
            // instancier un objet client pointant vers le client d'origine dans la collection            
            Client leClient = DonneesClient.ArrayStag[iClie] as Client;

            // instancier un form détail pour ce client             
            frmUpdClie frmVisualiser = new frmUpdClie(leClient);
            // afficher le form détail en modal             
            frmVisualiser.ShowDialog();

            // en sortie du form détail, rafraichir la datagridview             
            this.listeClients();

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            // ouvrir la feuille détail en y affichant              
            // le client correspondant à la ligne sélectionnée 

            Int32 iClie;        // rang du client dans la liste 

            // récupérer indice du client sélectionné en DataGridView             
            iClie = this.grdClie.CurrentRow.Index;

            // instancier un objet client pointant vers le client d'origine dans la collection            
            Client leClient = DonneesClient.ArrayStag[iClie] as Client;

            // instancier un form détail pour ce client             
            frmUpdClie frmVisualiser = new frmUpdClie(leClient);
            // afficher le form détail en modal             
            frmVisualiser.ShowDialog();

            // en sortie du form détail, rafraichir la datagridview             
            this.listeClients();




        }

        private void btnRechercher_Click(object sender, EventArgs e)

        {

            
            // Si aucune saisie dans champs de recherche, affichage de la liste complète des clients
            if (txtNom.Text == null && txtDomaine.Text == null && txtMotCle.Text == null)
            {
                MessageBox.Show("Vous n'avez pas entré de critères de recherche");
            }

            //Si saisie dans champ de recherche Nom
            if (this.txtNom.Text != null)
            {
                ((DataView)(this.grdClie.DataSource)).RowFilter = "Nom like '%" + txtNom.Text + "%'";
            }

            //Si saisie dans champ de recherche Domaine
            if (this.txtDomaine != null)
            {
                ((DataView)(this.grdClie.DataSource)).RowFilter = "Activite like '%" + txtDomaine.Text + "%'";
            }

            /*
            //Si saisie dans champ de recherche Mot clé
            if (this.txtMotCle != null)
            {
                ((DataView)(this.grdClie.DataSource)).RowFilter = "Nom like '%" + txtNom.Text + "%'";
                ((DataView)(this.grdClie.DataSource)).RowFilter = "Domaine like '%" + txtDomaine.Text + "%'";
                
            }
            */




            if (this.grdClie.Rows.Count == 1)
            {
                MessageBox.Show("Client n'existant pas!");
            }

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // ouvrir la feuille détail en y affichant              
            // le client correspondant à la ligne sélectionnée 

            Int32 iClie;        // rang du client dans la liste 

            // récupérer indice du client sélectionné en DataGridView             
            iClie = this.grdClie.CurrentRow.Index;

            // instancier un objet client pointant vers le client d'origine dans la collection            
            Client leClient = DonneesClient.ArrayStag[iClie] as Client;

            // instancier un form détail pour ce client             
            frmDelClie frmVisualiser = new frmDelClie(leClient);
            // afficher le form détail en modal             
            frmVisualiser.ShowDialog();

            // en sortie du form détail, rafraichir la datagridview             
            this.listeClients();
        }
    }
}
