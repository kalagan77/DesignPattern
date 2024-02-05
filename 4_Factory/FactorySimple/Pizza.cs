namespace _4_Factory.FactorySimple
{
    public class Pizza
    {
        public string nom;
        public string pate;
        public string sauce;
        public List<string> garnitures = new List<string>();
        public void Preparer()
        {
            Console.WriteLine("préparation de " + nom);
            foreach (string item in garnitures)
            {
                Console.WriteLine(" " + item);
            }
        }
        public void Cuire()
        {
            Console.WriteLine("Cuisson de 25min");
        }
        public virtual void Couper()
        {
            Console.WriteLine("découpe en parts triangulaires");
        }
        public void Emballer()
        {
            Console.WriteLine("Emballage dans une boite officielle");
        }
    }
}
