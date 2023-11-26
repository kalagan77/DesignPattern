using SuperCanard.Interface;

namespace SuperCanard.Comportement
{
    internal class NePasVoler : IVoler
    {
        public void Voler()
        {
            Console.WriteLine("je ne sais pas voler");
        }
    }
}
