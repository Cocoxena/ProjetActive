using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetActive
{
    class MIntervenant
    {
        // Nom du contact
        private String nomContact;

        // Prénom du Contact
        private String prenomContact;

        // Téléphone du Contact
        private String telephoneContact;

        // numéro du client (6 chiffres) auquel ce contact est lié
        private Int32 idClient;

        // nom du client
        private String nomClient;

        // nom du projet
        private String nomProjet;

        // code du projet
        private String idProjet;  

        // fonction dans le projet
        private String fonctionContact;

        // durée d'intervention du contact sur le projet (en heures)
        private Int32 dureeInterventionContact;

        // numéro du contact
        // s'obtiendra une fois la fiche créée
        // numéro à 6 chiffres commençant par 000001
        private Int32 idContact;

        public string NomContact { get => nomContact; set => nomContact = value; }
        public string PrenomContact { get => prenomContact; set => prenomContact = value; }
        public string TelephoneContact { get => telephoneContact; set => telephoneContact = value; }
        public int IdClient { get => idClient; set => idClient = value; }
        public string NomClient { get => nomClient; set => nomClient = value; }
        public string NomProjet { get => nomProjet; set => nomProjet = value; }
        public string IdProjet { get => idProjet; set => idProjet = value; }
        public string FonctionContact { get => fonctionContact; set => fonctionContact = value; }
        public int DureeInterventionContact { get => dureeInterventionContact; set => dureeInterventionContact = value; }
        public int IdContact { get => idContact; set => idContact = value; }
       
    }
}
