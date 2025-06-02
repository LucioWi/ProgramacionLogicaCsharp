using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMLibros1w2.Datos 
{
    public class Parametro
    {
        private string nombre;
        private object valor;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public object Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        public Parametro(string nombre, object valor)
        {
            this.nombre = nombre;
            this.valor = valor;
        }

    }
}
