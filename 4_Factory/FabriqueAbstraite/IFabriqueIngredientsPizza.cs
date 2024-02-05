using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using _4_Factory.Fabrique.Ingredients;

namespace _4_Factory.Fabrique
{
    //fabrique abstraite
    public interface IFabriqueIngredientsPizza
    {
        public IPate creerPate();
        public ISauce creerSauce();
        public IFromage creerFromage();
        public List<ILegumes> creerLegumes();
        public IPoivrons creerPoivrons();
        public IMoules creerMoules();
    }
}
