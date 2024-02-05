using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Factory.FactorySimple
{
    public abstract class Pizzeria
    {
        public Pizza CommanderPizza(string type)
        {
            Pizza pizza;
            pizza = CreerPizza(type);

            pizza.Preparer();
            pizza.Cuire();
            pizza.Couper();
            pizza.Emballer();

            return pizza;
        }

        protected abstract Pizza CreerPizza(string type);
    }
}
