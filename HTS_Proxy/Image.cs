using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTS_Proxy
{
    public interface IImage
    {
        void DisplayImage();
    }

    public class Image : IImage
    {
        private readonly string _filename;
        private byte[] data;

        public Image(string filename)
        {
            _filename = filename;
            Thread.Sleep(1000);
        }

        public void DisplayImage()
        {
            Console.WriteLine("Affichage de l'image - Implémentation");
        }
    }

    public class ImageProxy : IImage
    {
        private readonly string _filename;
        public ImageProxy(string filename)
        {
            _filename = filename;
        }
        public void DisplayImage()
        {
            Image image = new Image(this._filename);
            Console.WriteLine("Affichage de l'image - Implémentation");
        }
    }


}
