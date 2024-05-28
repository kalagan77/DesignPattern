using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Etat
{
    internal class Distributeur
    {
        private TypeEtat etat = TypeEtat.EPUISE;
        private int _nombre = 0;

        public Distributeur(int nombre)
        {
            _nombre = nombre;
            if(nombre > 0)
            {
                etat = TypeEtat.SANS_PIECE;
            }
                
        }

    }
}
