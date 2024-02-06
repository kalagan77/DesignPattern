using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Commande
{
    public class PorteGarage
    {
        public void ouvrir() {
            Console.WriteLine("ouvrir garage");
        }
        public void fermer()
        {
            Console.WriteLine("fermer garage");
        }
        public void stop()
        {
            Console.WriteLine("stop garage");
        }
        public void lampeAllumee()
        {
            Console.WriteLine("lampeAllumee garage");
        }
        public void lampeEteinte()
        {
            Console.WriteLine("lampeEteinte garage");
        }
    }
}
