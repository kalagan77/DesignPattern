using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Decorateur
{
    public class Colombia : Boisson
    {
        public Colombia()
        {
            description = "Pur Colombia";
        }

        public override double Cout()
        {
            return 0.89;
        }
    }
}
