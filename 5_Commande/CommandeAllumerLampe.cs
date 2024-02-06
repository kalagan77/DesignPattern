namespace _5_Commande
{
    public class CommandeAllumerLampe : ICommande
    {
        Lampe lampe;
        public CommandeAllumerLampe(Lampe l)
        {
            lampe = l;
        }
        public void Executer()
        {
            lampe.marche();
        }
    }
}
