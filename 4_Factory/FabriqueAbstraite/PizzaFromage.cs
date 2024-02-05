using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Factory.Fabrique
{
    public class PizzaFromage : Pizza
    {
        private readonly IFabriqueIngredientsPizza _fabriqueIngredients;

        public PizzaFromage(IFabriqueIngredientsPizza fabriqueIngredients)
        {
            _fabriqueIngredients = fabriqueIngredients;
        }

        //public PizzaFromage()
        //{
        //    _fabriqueIngredients = new FabriqueIngredientsPizzaBrest();
        //}

        public override void preparer()
        {
            pate = _fabriqueIngredients.creerPate();
            sauce = _fabriqueIngredients.creerSauce();
            legume = _fabriqueIngredients.creerLegumes();
            fromage = _fabriqueIngredients.creerFromage();
            poivrons = _fabriqueIngredients.creerPoivrons();
            moules = _fabriqueIngredients.creerMoules();
        }
    }
}
