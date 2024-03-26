namespace _7_PatronMethode
{
    public class The : BoissonCafeine
    {
        protected override void AjouterSupplement()
        {
            Console.WriteLine("Infusion thé");
        }

        protected override void Preparer()
        {
            Console.WriteLine("Ajout citron");
        }
    }
}
