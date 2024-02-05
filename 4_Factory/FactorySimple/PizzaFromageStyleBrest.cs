namespace _4_Factory.FactorySimple
{
    public class PizzaFromageStyleBrest : Pizza
    {
        public PizzaFromageStyleBrest()
        {
            nom = "Pizza sauce style brest et fromage";
            pate = "pate fine";
            sauce = "sauce marinara";

            garnitures.Add("Parmigiano reggiano rapé");
        }

        public override void Couper()
        {
            Console.WriteLine("découpe en parts carrées");
        }
    }
}