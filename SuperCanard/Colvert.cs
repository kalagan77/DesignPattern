using SuperCanard.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCanard
{
    public class Colvert : SuperCanard
    {
        private readonly IVoler _voler;

        public override void Cancaner()
        {
            Console.WriteLine("Je cancane");
        }

        public override void Afficher()
        {
            Console.WriteLine("Je suis un colvert");
        }
    }
}
