using SuperCanard.Interface;

namespace SuperCanard.Comportement
{
    public class VolerAvecDesAiles : IVoler
    {
        public void Voler()
        {
            Console.WriteLine("je vole avec des ailes");
        }
    }
}
