using _4_Factory.Fabrique.Ingredients;

namespace _4_Factory.Fabrique
{
    public abstract class Pizza
    {
        protected String nom;
        protected IPate pate;
        protected ISauce sauce;
        protected List<ILegumes> legume;
        protected IFromage fromage;
        protected IPoivrons poivrons;
        protected IMoules moules;

        public abstract void preparer();
        public void cuire()
        {
            Console.WriteLine("Cuisson 25 minutes à 180°");
        }
        public void couper()
        {
            Console.WriteLine("Découpage en parts triangulaires");
        }
        public void emballer()
        {
            Console.WriteLine("Emballage dans une boîte officielle");
        }
        private void setNom(String nom)
        {
            this.nom = nom;
        }
        public String getNom()
        {
            return nom;
        }
        public String toString()
        {
            return null;
        }
    }
}
