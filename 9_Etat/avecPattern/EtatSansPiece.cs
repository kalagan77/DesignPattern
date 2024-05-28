using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Etat.avecPattern
{
    internal class EtatSansPiece : IEtat
    {
        private readonly Distributeur _distributeur;
        public EtatSansPiece(Distributeur distributeur)
        {
            _distributeur = distributeur;
        }

        public void Delivrer()
        {
            Console.WriteLine("Il faut payer d'abord");
        }

        public void EjecterPiece()
        {
            Console.WriteLine("Vous n'avez pas inséré de pièce");
        }

        public void InsererPiece()
        {
            Console.WriteLine("Vous avez inséré une pièce");
            _distributeur.SetEtat(_distributeur._etatAPiece);
        }

        public void TournerPoingee()
        {
            Console.WriteLine("Vous avez tourné, mais il n'y a pas de pièce");
        }
    }
}
