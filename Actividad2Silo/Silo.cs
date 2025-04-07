using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2Silo
{
    public class Silo
    {
        private double radio;
        private double altura;

        public double Radio
        {
            get { return radio; }
            set { radio = value; }
        }

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public double CalcularVolumen()
        {
            return Math.PI * Math.Pow(radio, 2) * altura;
        }
    }
}
