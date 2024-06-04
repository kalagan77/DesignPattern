using _9_Etat.SansPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Etat.avecPattern
{
    internal class EtatGagnant : IEtat
    {
        private readonly Distributeur _distributeur;
        public EtatGagnant(Distributeur distributeur)
        {
            _distributeur = distributeur;
        }

        public void Delivrer()
        {
            Console.WriteLine("Vous avez gagné 2 bonbons pour le prix d'un !");
            _distributeur.Liberer();
            //blablabla
        }

        public void EjecterPiece()
        {
            throw new NotImplementedException();
        }

        public void InsererPiece()
        {
            throw new NotImplementedException();
        }

        public void TournerPoingee()
        {
            throw new NotImplementedException();
        }
    }
}
