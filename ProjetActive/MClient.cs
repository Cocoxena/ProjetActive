using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetActive
{

    public class MClient
    {
        // nombre de clients enregistrés dans la liste
        public static Int32 NClie;
        
        // numéro du client
        // s'obtiendra une fois la fiche créée
        // numéro à 6 chiffres commençant par 000001
        private Int32 idClient;

        // raison sociale du client = nom
        private String raisonSocialeClient;

        // type du client (privé ou public)
        private String typeSocieteClient;

        // domaine d'activité du client
        private String activiteClient;

        // adresse du client
        // format libre: numéro, rue, immeuble
        private String adresseClient;

        // code postal du client
        // code postal valable si et seulement si 5 chiffres
        private String codePostalClient;

        // ville du client
        private String villeClient;

        // téléphone du client
        private String telephoneClient;

        // chiffre d'affaires du client
        private decimal cAClient;

        // effectif du client
        private Int32 effectifClient;

        // nature du client (principale, secondaire ou ancienne) 
        private String natureClient;

        // liste de contacts du client
        private String listeContactsClient;

        /// <summary>
        /// Propriétés des données rendues publiques 
        /// </summary>
        public Int32 IdClient
        {
            get { return this.idClient; }
            set { this.idClient = value; }
        }

        public String RaisonSocialeClient
        {
            get { return this.raisonSocialeClient; }
            set { this.raisonSocialeClient = value; }
        }

        public string TypeSocieteClient { get => typeSocieteClient; set => typeSocieteClient = value; }
        public string ActiviteClient { get => activiteClient; set => activiteClient = value; }
        public string AdresseClient { get => adresseClient; set => adresseClient = value; }

        public string VilleClient { get => villeClient; set => villeClient = value; }

        public string TelephoneClient
        {
            get { return telephoneClient; }

            set
            {
                // le téléphone doit être composé de 10 chiffres             
                Int32 i;                      // variable de boucle             
                Boolean erreur = false;        // indicateur erreur            
                if (value.Length == 10)        // 10 caractères attendus : OK ==> contrôler un à un             
                {
                    for (i = 0; i < value.Length; i++)       // contrôle chiffres par boucle                 
                    {
                        if (!(Char.IsDigit(value[i])))
                        { erreur = true; }

                    } // fin de boucle controle chiffres                
                    if (erreur)                             // on a rencontré un non-chiffre                 
                    {
                        System.Windows.Forms.MessageBox.Show(value.ToString() + "\n" + "n'est pas un numéro de téléphone valide : uniquement des chiffres", "Erreur Classe MClient", System.Windows.Forms.MessageBoxButtons.OK);
                    }
                    else
                    {
                        telephoneClient = value;       // tout est bon, on affecte la propriété 
                    }
                }
                else // il n'y a pas 10 caractères 
                {
                    // première solution par simple messagebox         
                    System.Windows.Forms.MessageBox.Show(value.ToString() + "\n" + "n'est pas un numéro de téléphone valide : 10 chiffres, pas plus, pas moins", "Erreur Classe MClient", System.Windows.Forms.MessageBoxButtons.OK);
                }

            }

        }

        public decimal CAClient { get => cAClient; set => cAClient = value; }
        public int EffectifClient { get => effectifClient; set => effectifClient = value; }
        public string Nature { get => natureClient; set => natureClient = value; }


        public string CodePostalClient
        {
            get { return codePostalClient; } // en lecture, retourne la var privée 

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
                        System.Windows.Forms.MessageBox.Show(value.ToString() + "\n" + "n'est pas un code postal valide : uniquement des chiffres", "Erreur MClient", System.Windows.Forms.MessageBoxButtons.OK);
                    }
                    else
                    {
                        codePostalClient = value;       // tout est bon, on affecte la propriété 
                    }
                }
                else // il n'y a pas 5 caractères 
                {
                    // première solution par simple messagebox         
                    System.Windows.Forms.MessageBox.Show(value.ToString() + "\n" + "n'est pas un code postal valide : 5 chiffres, pas plus, pas moins", "Erreur MClient", System.Windows.Forms.MessageBoxButtons.OK);
                }

            }
        }

        public string ListeContactsClient { get => listeContactsClient; set => listeContactsClient = value; }
    }
}
