using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Decorateur
{
    public abstract class DecorateurIngredient : Boisson
    {
        public new abstract string GetDescription();
    }
    
}
