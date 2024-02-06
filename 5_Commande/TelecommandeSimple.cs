namespace _5_Commande
{
    /// <summary>
    /// telecommande avec un seul emplacement, et un seul bouton marche !
    /// </summary>
    public class TelecommandeSimple
    {
        private ICommande emplacement;
        public TelecommandeSimple() { }

        public void SetCommande(ICommande commande)
        {
            emplacement = commande;
        }

        public void BoutonPresse()
        {
            emplacement.Executer();
        }

    }
}
