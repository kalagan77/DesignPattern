using SuperCanard.Interface;

namespace SuperCanard
{
    public abstract class Canard
    {
        protected  IVoler _voler;
        protected  ICancaner _cancaner;

        //A mettre également dans une interface ICancaner, comme IVoler
        public virtual void EffectuerVol()
        {
            _voler.Voler();
        }

        public virtual void EffectuerCancan()
        {
            _cancaner.Cancaner();
        }
        public void ChangerComportementVol(IVoler voler)
        {
            _voler = voler;
        }

        public void ChangerComportementCancaner(ICancaner cancaner)
        {
            _cancaner = cancaner;
        }

        public void Nager()
        {
            Console.WriteLine("Je nage");
        }


        public abstract void Afficher();

    }
}