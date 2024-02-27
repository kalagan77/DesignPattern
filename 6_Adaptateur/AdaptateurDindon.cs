using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Adaptateur
{
    public class AdaptateurDindon : ICanard
    {
        Dindon _dindon;
        public AdaptateurDindon(Dindon dindon)
        {
            _dindon = dindon;
        }

        public void Cancaner()
        {
            _dindon.Glouglouter();
        }

        public void Voler()
        {
            _dindon.Voler();
        }
    }
}
