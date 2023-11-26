using SuperCanard.Comportement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCanard
{
    public class PrototypeCanard : Canard
    {
        public PrototypeCanard()
        {
            _voler = new NePasVoler();
            _cancaner = new Coincoin();
        }
        public override void Afficher()
        {
            Console.WriteLine("je suis un prototype");
        }
    }
}
