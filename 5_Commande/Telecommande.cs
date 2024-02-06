using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Commande
{
    /// <summary>
    /// telecommande avec 7 emplacement
    /// 1 bouton marche + 1 bouton arrêt
    /// </summary>
    public class Telecommande
    {
        ICommande[] CommandeMarche;
        ICommande[] CommandeArret;
        public Telecommande()
        {
            int[] tab = new int[7];
            CommandeMarche = new ICommande[7];
            CommandeArret = new ICommande[7];
        }

        public void SetCommande(int emplacement, ICommande marche, ICommande arret)
        {
            CommandeMarche[emplacement] = marche;
            CommandeArret[emplacement] =  arret;
        }

        public void CommandeMarchePresse(int emplacement)
        {
            CommandeMarche[emplacement].Executer();
        }

        public void CommandeArretPresse(int emplacement)
        {
            CommandeArret[emplacement].Executer();
        }
    }
}
