using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Commande
{
    public class CommandeAllumerStereoAvecCD : ICommande
    {
        Stereo stereo;
        public CommandeAllumerStereoAvecCD(Stereo s)
        {
            stereo = s;
        }
        public void Executer()
        {
            stereo.marche();
            stereo.setCd();
            stereo.setVolume();
        }
    }
}
