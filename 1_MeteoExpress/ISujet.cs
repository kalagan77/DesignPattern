using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_MeteoExpress
{
    public interface ISujet
    {
        public void EnregistrerObservateur(IObservateur obs);
        public void SupprimerObservateur(IObservateur obs);
        public void NotifierObservateurs();
        public void SetMesures(float temperature, float humidite, float pression);
    }
}
