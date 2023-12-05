using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Decorateur
{
    public class IngredientCaramel : DecorateurIngredient
    {
        private Boisson _boisson;

        public IngredientCaramel(Boisson boisson)
        {
                _boisson = boisson;
        }


        public override string GetDescription()
        {
            return _boisson.GetDescription() + ", caramel";
        }

        public override double Cout()
        {
            return 0.50;
        }
    }
}
