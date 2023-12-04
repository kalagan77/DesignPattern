using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_MeteoExpress
{
    public class AffichageConditions : IObservateur, IAffichage
    {
        private ISujet _donneesMeteo;
        private InfoMeteo _infoMeteo;

        public AffichageConditions(ISujet donneesMeteo) {
            _donneesMeteo = donneesMeteo;
            donneesMeteo.EnregistrerObservateur(this);
        }

        public void Actualiser(InfoMeteo infoMeteo)
        {
            _infoMeteo = infoMeteo;
            Afficher();
        }

        public void Afficher()
        {
            Console.WriteLine($"Conditions actuelles : {_infoMeteo.temperature}° et humidité {_infoMeteo.humidite}%");
        }
    }
}
