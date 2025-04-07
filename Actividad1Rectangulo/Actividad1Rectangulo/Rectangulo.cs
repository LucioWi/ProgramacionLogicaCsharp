using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1Rectangulo
{
    public class Rectangulo
    {
        private int ancho;
        private int alto;

        public int Ancho
        {
            get { return ancho; }
            set { ancho = value; }
        }
        public int Alto
        {
            get { return alto; }
            set { alto = value; }
        }

        public int CalcularPer()
        {
            return 2 * (Ancho + Alto);
        }

        public int CalcularSup()
        {
            return Ancho * Alto;
        }
    }
}
