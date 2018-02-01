using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; // ajouté manuellement

namespace ProjetActive
{
    /// <summary>
    /// classe générale des données client à gérer
    /// regroupe les données de l'application de gestion des clients
    /// dans une collection d'objets définie en static
    /// </summary>
    public class DonneesClient
    {
        /*public static ArrayList ArrayStag = new ArrayList();*/
        public static ActiveEntities Db = new ActiveEntities();
    }
}
