using SuperCanard.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCanard.Comportement
{
    public class PropulsionAReaction : IVoler
    {
        public void Voler()
        {
            Console.WriteLine("je vole avec un réacteur");
        }
    }
}
