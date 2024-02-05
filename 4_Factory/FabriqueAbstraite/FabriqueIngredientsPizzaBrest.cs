using _4_Factory.Fabrique.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Factory.Fabrique
{
    public class FabriqueIngredientsPizzaBrest : IFabriqueIngredientsPizza
    {
        public IFromage creerFromage()
        {
            throw new NotImplementedException();
        }

        public List<ILegumes> creerLegumes()
        {
            throw new NotImplementedException();
        }

        public IMoules creerMoules()
        {
            throw new NotImplementedException();
        }

        public IPate creerPate()
        {
            throw new NotImplementedException();
        }

        public IPoivrons creerPoivrons()
        {
            throw new NotImplementedException();
        }

        public ISauce creerSauce()
        {
            throw new NotImplementedException();
        }
    }
}
