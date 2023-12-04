namespace _1_MeteoExpress
{
    public class DonneesMeteo : ISujet
    {
        private List<IObservateur> observateurs;
        private InfoMeteo _infoMeteo;

        public DonneesMeteo()
        {
            observateurs = new List<IObservateur>();
            _infoMeteo = new InfoMeteo();
        }
        public void EnregistrerObservateur(IObservateur obs)
        {
            observateurs.Add(obs);
        }
        public void SupprimerObservateur(IObservateur obs)
        {
            int indexObs = observateurs.IndexOf(obs);
            if(indexObs > -1)
            {
                observateurs.RemoveAt(indexObs);
            }
        }

        public void NotifierObservateurs()
        {
            foreach (var obs in observateurs)
            {
                obs.Actualiser(_infoMeteo);
            }
        }

        public void ActualiserMesures()
        {
            NotifierObservateurs();
        }

        public void SetMesures(float temperature,float humidite,float pression){
            _infoMeteo.temperature= temperature; 
            _infoMeteo.humidite = humidite;
            _infoMeteo.pression = pression;
            ActualiserMesures();
        }
    }
}