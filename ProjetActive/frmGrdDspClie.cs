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
            
            // ajout à la datatable de 3 colonnes personnalisées 
            dt.Columns.Add(new DataColumn("Numéro", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("Nom", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Type", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Domaine", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Adresse", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Code Postal", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Ville", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Telephone", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Chiffres Affaires", typeof(System.Decimal)));
            dt.Columns.Add(new DataColumn("Effectif", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("Nature", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Liste de Contacts", typeof(System.String)));

            // boucle remplissage de la DataTable à partir de la collection  
            foreach (Client unClientEF in DonneesClient.Db.Client.ToList())
            {
                // instanciation DataRow (=ligne de DataTable)                 
                dr = dt.NewRow();
                // affectation des 12 colonnes à partir de l'Entity                                  
                dr[0] = unClientEF.IdClient;
                dr[1] = unClientEF.RaisonSociale;
                dr[2] = unClientEF.TypeSociete;
                dr[3] = unClientEF.Activite;
                dr[4] = unClientEF.Adresse;
                dr[5] = unClientEF.CodePostal;
                dr[6] = unClientEF.Ville;
                dr[7] = unClientEF.Telephone;
                dr[8] = unClientEF.CA;
                dr[9] = unClientEF.Effectif;
                dr[10] = unClientEF.Nature;
                dr[11] = unClientEF.ListeContacts;
                

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
            
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            // ouvrir la feuille détail en y affichant              
            // le client correspondant à la ligne double-cliquée 

            Int32 idClie;        // rang du client dans la liste 

            // récupérer indice du client cliqué en DataGridView             
            idClie = (int)this.grdClie.CurrentRow.Cells[0].Value;

            // rechercher l'objet Entity
            Client leClientEF = DonneesClient.Db.Client.Find(idClie);

            // affecter de nouvelles données au client
            Client leClient = new Client();
            leClient.IdClient = leClientEF.IdClient;
            leClient.RaisonSociale = leClientEF.RaisonSociale;
            leClient.TypeSociete = leClientEF.TypeSociete;
            leClient.Activite = leClientEF.Activite;
            leClient.Adresse = leClientEF.Adresse;
            leClient.CodePostal = leClientEF.CodePostal;
            leClient.Ville = leClientEF.Ville;
            leClient.Telephone = leClientEF.Telephone;
            leClient.CA = leClientEF.CA;
            leClient.Effectif = leClientEF.Effectif;
            leClient.Nature = leClientEF.Nature;

            // instancier un form pour visualiser la fiche client
            frmUpdClie frmVisualiser = new frmUpdClie(leClient);
            // afficher le form détail en modal             
            frmVisualiser.ShowDialog();
             
            // sauvegarde des nouvelles données
            DonneesClient.Db.SaveChanges();
            
            // en sortie du form détail, rafraichir la datagridview             
            this.listeClients();
        }



        private void btnRechercher_Click(object sender, EventArgs e)

        {
            
            //Si saisie dans champ de recherche Nom
            if (this.txtNom.Text != null)
            {
                ((DataView)(this.grdClie.DataSource)).RowFilter = "Nom like '%" + txtNom.Text + "%'";
            }

            /*
            //Si saisie dans champ de recherche Domaine
            if (this.txtDomaine != null)
            {
                ((DataView)(this.grdClie.DataSource)).RowFilter = "Domaine like '%" + txtDomaine.Text + "%'";
            }
            */

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
            // le client correspondant à la ligne double-cliquée 

            Int32 iClie;        // rang du client dans la liste 

            // récupérer indice du client cliqué en DataGridView             
            iClie = (int)this.grdClie.CurrentRow.Cells[0].Value;

            // rechercher l'objet Entity
            Client leClientEF = DonneesClient.Db.Client.Find(iClie);

            // instancier un objet Métier Client et le renseigner à partir de l'Entity dans le form
            Client leClient = new Client();
            leClient.IdClient = leClientEF.IdClient;
            leClient.RaisonSociale = leClientEF.RaisonSociale;
            leClient.TypeSociete = leClientEF.TypeSociete;
            leClient.Activite = leClientEF.Activite;
            leClient.Adresse = leClientEF.Adresse;
            leClient.CodePostal = leClientEF.CodePostal;
            leClient.Ville = leClientEF.Ville;
            leClient.Telephone = leClientEF.Telephone;
            leClient.CA = leClientEF.CA;
            leClient.Effectif = leClientEF.Effectif;
            leClient.Nature = leClientEF.Nature;

            // instancier un form pour visualiser la fiche client
            frmDelClie frmVisualiser = new frmDelClie(leClient);
            // afficher le form détail en modal             
            frmVisualiser.ShowDialog();

            
            DialogResult reponse;
            reponse = MessageBox.Show("Voulez-vous vraiment supprimer cette fiche client, car tous les contacts associés seront supprimés également?", "Supprimer?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); ;

            if (reponse == DialogResult.Yes)
            {
                
                // supprimer le client de la liste
                DonneesClient.Db.Client.Remove(leClientEF);
                

                // impacter dans la BdD
                DonneesClient.Db.SaveChanges();
                this.DialogResult = DialogResult.OK;
            }
                    
            // en sortie du form détail, rafraichir la datagridview             
            this.listeClients();
        }


        /// <summary>         
        /// Double-clic sur le datagridview :  
        /// ouvrir la feuille détail en y affichant       
        /// le client correspondant à la ligne double-cliquée        
        /// </summary>         
        /// <param name="sender"></param>
        /// <param name="e"></param>   
        private void grdClie_DoubleClick(object sender, EventArgs e)
        {
            // ouvrir la feuille détail en y affichant              
            // le client correspondant à la ligne double-cliquée 

            Int32 iClie;        // rang du client dans la liste 

            // récupérer indice du client cliqué en DataGridView             
            iClie = (int)this.grdClie.CurrentRow.Cells[0].Value;

            // rechercher l'objet Entity
            Client leClientEF = DonneesClient.Db.Client.Find(iClie);

            // instancier un objet Métier Client et le renseigner à partir de l'Entity dans le form
            Client leClient = new Client();
            leClient.IdClient = leClientEF.IdClient;
            leClient.RaisonSociale = leClientEF.RaisonSociale;
            leClient.TypeSociete = leClientEF.TypeSociete;
            leClient.Activite = leClientEF.Activite;
            leClient.Adresse = leClientEF.Adresse;
            leClient.CodePostal = leClientEF.CodePostal;
            leClient.Ville = leClientEF.Ville;
            leClient.Telephone = leClientEF.Telephone;
            leClient.CA = leClientEF.CA;
            leClient.Effectif = leClientEF.Effectif;
            leClient.Nature = leClientEF.Nature;

            // instancier un form pour visualiser la fiche client
            frmUpdClie frmVisualiser = new frmUpdClie(leClient);
            // afficher le form détail en modal             
            frmVisualiser.ShowDialog();

            // en sortie du form détail, rafraichir la datagridview             
            this.listeClients();
        }
    }
}
