using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetActive
{
    /// <summary>
    /// Classe de client: permet de mémoriser les informations concernant un client
    /// comporte des propriétés et des attributs privés
    /// Données partagées par toutes les instances
    /// </summary>
    public class Client
    {
        // numéro du client
        // s'obtiendra une fois la fiche créée
        // numéro à 6 chiffres commençant par 000001
        private Int32 idClient;

        // raison sociale du client = nom
        private String raisonSociale;

        // type du client (privé ou public)
        private String typeSociete;

        // domaine d'activité du client
        private String activite;

        // adresse du client
        // format libre: numéro, rue, immeuble
        private String adresse;

        // code postal du client
        // code postal valable si et seulement si 5 chiffres
        private String codePostal;

        // ville du client
        private String ville;

        // téléphone du client
        private String telephone;

        // chiffre d'affaires du client
        private decimal cA;

        // effectif du client
        private Int32 effectif;

        // nature du client (principale, secondaire ou ancienne) 
        private String nature;

        /// <summary>
        /// Propriétés des données rendues publiques 
        /// </summary>
        public Int32 IdClient
        {
            get { return this.idClient; }
            set { this.idClient = value; }
        }
    
        public String RaisonSociale
        {
            get { return this.raisonSociale; }
            set { this.raisonSociale = value; }
        }

        public string TypeSociete { get => typeSociete; set => typeSociete = value; }
        public string Activite { get => activite; set => activite = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        
        public string Ville { get => ville; set => ville = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public decimal CA { get => cA; set => cA = value; }
        public int Effectif { get => effectif; set => effectif = value; }
        public string Nature { get => nature; set => nature = value; }


        public string CodePostal
        {
            get { return codePostal; } // en lecture, retourne la var privée 

            set      // la propriété en écriture effectue un contrôle de saisie
            {
                // le code postal doit être composé de 5 chiffres             
                Int32 i;                      // variable de boucle             
                Boolean erreur = false;        // indicateur erreur            
                if (value.Length == 5)        // 5 caractères attendus : OK ==> contrôler un à un             
                {
                    for (i = 0; i < value.Length; i++)       // contrôle chiffres par boucle                 
                    {
                        if (!(Char.IsDigit(value[i])))
                        { erreur = true; }

                    } // fin de boucle controle chiffres                
                    if (erreur)                            // on a rencontré un non-chiffre                 
                    {
                        System.Windows.Forms.MessageBox.Show(value.ToString() + "\n" + "n'est pas un code postal valide : uniquement des chiffres", "Erreur Classe MStagiaire", System.Windows.Forms.MessageBoxButtons.OK);
                    }
                    else
                    {
                        codePostal = value;       // tout est bon, on affecte la propriété 
                    }
                }
                else // il n'y a pas 5 caractères 
                {
                    // première solution par simple messagebox         
                    System.Windows.Forms.MessageBox.Show(value.ToString() + "\n" + "n'est pas un code postal valide : 5 chiffres, pas plus, pas moins", "Erreur Classe MStagiaire", System.Windows.Forms.MessageBoxButtons.OK);
                }

            }
        }

        /// <summary>
        /// Constructeur de la classe Client sous forme de liste
        /// </summary>

        

            



    }
}
