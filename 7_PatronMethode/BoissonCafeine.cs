namespace _7_PatronMethode
{
    public abstract class BoissonCafeine
    {
        protected abstract void Preparer();
        protected abstract void AjouterSupplement();

        private void FaireBouillir()
        {
            Console.WriteLine("Eau en ébullition");
        }

        private void VerserDansTasse()
        {
            Console.WriteLine("Verser dans tasse");
        }

        public void SuivreRecette()
        {
            FaireBouillir();
            Preparer();
            VerserDansTasse();
            AjouterSupplement();
        }
    }
}
