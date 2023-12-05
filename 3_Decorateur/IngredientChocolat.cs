using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Decorateur
{
    public class IngredientChocolat : DecorateurIngredient
    {
        private Boisson _boisson;

        public IngredientChocolat(Boisson boisson) {
            _boisson = boisson;
        }

        public override double Cout()
        {
            return 0.20 + _boisson.Cout();
        }

        public override string GetDescription()
        {
            return _boisson.GetDescription() + ", Chocolat";
        }
    }
}
