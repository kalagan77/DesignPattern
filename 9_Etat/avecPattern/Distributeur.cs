using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Etat.avecPattern
{
    internal class Distributeur
    {
        public IEtat   _etatEpuise;
        public IEtat   _etatAPiece;
        public IEtat   _etatSansPiece;    
        public IEtat   _etatVendu;
        public IEtat   _etatGagnant;    

        private IEtat etatCourant;
        int nombre = 0;

        public Distributeur(int nbBonbons) {
            _etatSansPiece = new EtatSansPiece(this);
            _etatAPiece = new EtatAPiece(this);
            _etatEpuise = new EtatEpuise(this);
            _etatVendu = new EtatVendu(this);
            _etatGagnant = new EtatGagnant(this);

            if (nbBonbons > 0)
            {
                etatCourant = _etatSansPiece;
            }
            else
            {
                etatCourant = _etatEpuise;
            }
        }

        public void InsererPiece()
        {
            etatCourant.InsererPiece();
        }

        public void EjecterPiece()
        {
            etatCourant.EjecterPiece();
        }

        public void TournerPoignee()
        {
            etatCourant.TournerPoingee();
            etatCourant.Delivrer();
        }

        public void Liberer()
        {
               Console.WriteLine("un bonbon va sortir");
            if(nombre != 0)
            {
                nombre--;
            }
        }

        public void GetEtatGagnant()
        {
            Console.WriteLine("un bonbon va sortir");
            if (nombre != 0)
            {
                nombre--;
            }
        }

        public void SetEtat(IEtat etat) { 
            etatCourant = etat; 
        }
    }
}
