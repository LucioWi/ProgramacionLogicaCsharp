using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1con1Rectangulo
{
    public class Rectangulo
    {
        private int ancho;
        private int alto;

        public int Ancho
        {
            get { return ancho; } //propiedades
            set { ancho = value; } //propiedades
        }
        public int Alto
        {
            get { return alto; } //propiedades
            set { alto = value; } //propiedades
        }

        public int CalcularPer() //metodos
        {
            return 2 * (Ancho + Alto);
        }

        public int CalcularSup() //metodos
        {
            return Ancho * Alto;
        }
    }
}
