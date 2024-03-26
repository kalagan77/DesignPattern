namespace _7_PatronMethode
{
    public class Cafe : BoissonCafeine
    {
        protected override void AjouterSupplement()
        {
            Console.WriteLine("Passage du café");
        }

        protected override void Preparer()
        {
            Console.WriteLine("Ajout du lait et du sucre");
        }
    }
}
