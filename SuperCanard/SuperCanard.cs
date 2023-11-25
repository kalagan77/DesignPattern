namespace SuperCanard
{
    public abstract class SuperCanard
    {
        
        //A mettre également dans une interface ICancaner, comme IVoler
        public virtual void Cancaner()
        {
            Console.WriteLine("Je cancane");
        }
        public void Nager()
        {
            Console.WriteLine("Je nage");
        }


        public abstract void Afficher();

    }
}