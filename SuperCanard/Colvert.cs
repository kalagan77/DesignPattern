using SuperCanard.Comportement;

namespace SuperCanard
{
    public class Colvert : Canard
    {
        public Colvert()
        {
            _cancaner = new Coincoin();
            _voler = new VolerAvecDesAiles();
        }

 
        public override void Afficher()
        {
            Console.WriteLine("Je suis un colvert");
        }
    }
}
