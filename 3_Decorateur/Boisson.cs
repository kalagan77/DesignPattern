namespace _3_Decorateur
{
    public abstract class Boisson
    {
        protected string description = "Boisson inconnue";

        public string GetDescription() { return description; }

        public abstract double Cout();
    }
}
