using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Decorateur
{
    public class Espresso : Boisson
    {
        public Espresso() {
            description = "Espresso";
        }

        public override double Cout()
        {
            return 1.99;
        }
    }
}
