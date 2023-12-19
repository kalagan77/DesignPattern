using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Factory
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

        public abstract Pizza CreerPizza(string type);
    }
}
