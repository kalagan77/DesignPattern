using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Factory.Fabrique
{
    public abstract class Pizzeria
    {
        public Pizza CommanderPizza(string type)
        {
            Pizza pizza;
            pizza = CreerPizza(type);

            pizza.preparer();
            pizza.cuire();
            pizza.couper();
            pizza.emballer();

            return pizza;
        }

        protected abstract Pizza CreerPizza(string type);
    }
}
