using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace CargaImagen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dirección de la imagen que se mostrará en pantalla (usar doble diagonal invertida para que funcione).
            string imagen = "C:\\Users\\alumno\\Pictures\\lenna.jpg";

            Image<Bgr, byte> img = new Image<Bgr, byte>(imagen);
        }
    }
}
