namespace _3_Decorateur.VersionHTS
{
    //décorateur de données
    public class Personne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
    }

    public class PersonWrapper
    {
        private Personne personne;
        public string Nom
        {
            get => personne.Nom;
            set => personne.Nom = value;
        }

        public DateTime DateInscription { get; set; }
        public string NomComplet => $"{personne.Prenom} {personne.Nom}";

        public PersonWrapper(Personne p)
        {
            personne = p;
        }
    }




    //décorateur comportemental
    public interface INewsLetterSender
    {
        Task<bool> SendNewsLetter(string contenu);
    }

    public class AzureNewsLetter : INewsLetterSender
    {
        public Task<bool> SendNewsLetter(string contenu)
        {
            Console.WriteLine("Newsletter envoyé depuis Azure");
            return Task.FromResult(true);
        }
    }

    public abstract class NewsLetterDecorateur : INewsLetterSender
    {
        private readonly INewsLetterSender _newsLetter;
        public NewsLetterDecorateur(INewsLetterSender newsletter) {
            _newsLetter = newsletter;
        }

        public virtual Task<bool> SendNewsLetter(string contenu)
        {
            return _newsLetter.SendNewsLetter(contenu);
        }
    }

    public class DatabaseNewsLetterDecorateur : NewsLetterDecorateur
    {
        public DatabaseNewsLetterDecorateur(INewsLetterSender newsletter) : base(newsletter)
        {

        }

        public override Task<bool> SendNewsLetter(string contenu)
        {
            Console.WriteLine("Newsletter sauvegardé en base" + contenu);
            return base.SendNewsLetter(contenu);
        }
    }

    public class StatistiqueNewsLetterDecorateur : NewsLetterDecorateur
    {
        public static int NbletterEnvoye = 0;
        public StatistiqueNewsLetterDecorateur(INewsLetterSender newsletter) : base(newsletter)
        {

        }

        public override Task<bool> SendNewsLetter(string contenu)
        {
            NbletterEnvoye++;
            Console.WriteLine("send depuis statistique " + contenu);
            return base.SendNewsLetter(contenu);
        }

    }

}
