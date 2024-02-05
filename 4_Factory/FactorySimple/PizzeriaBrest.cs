using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Factory.FactorySimple
{
    public class PizzeriaBrest : Pizzeria
    {

        protected override Pizza CreerPizza(string type)
        {
            if (type.Equals("fromage"))
            {
                return new PizzaFromageStyleBrest();
            }
            //else if (type.Equals("vegetarienne"))
            //{
            //    return new PizzaVegetarienneStyleBrest();
            //}
            //else if (type.Equals("fruitsDeMer"))
            //{
            //    return new PizzaFruitsDeMerStyleBrest();
            //}
            //else if (type.Equals("poivrons"))
            //{
            //    return new PizzaPoivronsStyleBrest();
            //}
            else return null;
        }
    }
}
