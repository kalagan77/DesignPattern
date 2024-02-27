using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Adaptateur
{
    public class AdaptateurCanard : IDindon
    {
        Canard _canard;
        public AdaptateurCanard(Canard canard)
        {   
            _canard= canard;
        }

        public void Glouglouter()
        {
            _canard.Cancaner();
        }

        public void Voler()
        {
            _canard.Voler();
        }
    }
}
