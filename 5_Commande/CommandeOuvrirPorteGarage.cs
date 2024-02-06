using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Commande
{
    public class CommandeOuvrirPorteGarage : ICommande
    {
        PorteGarage porteGarage;
        public CommandeOuvrirPorteGarage(PorteGarage porte)
        {
            porteGarage = porte;
        }
        public void Executer()
        {
            porteGarage.ouvrir();
        }
    }
}
