using _9_Etat.SansPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Etat.avecPattern
{
    internal class EtatEpuise : IEtat
    {
        private readonly Distributeur _distributeur;
        public EtatEpuise(Distributeur distributeur)
        {
            _distributeur = distributeur;
        }

        public void Delivrer()
        {
            throw new NotImplementedException();
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
