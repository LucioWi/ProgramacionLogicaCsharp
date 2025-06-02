using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMLibros1w2.Negocio
{
    public class Libro
    {
        private int codigo;
        private string titulo;
        private double precio;
        private Autor autor;
        private int formato;
        private DateTime fecha;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Titulo    
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public Autor Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        public int Formato
        {
            get { return formato; }
            set { formato = value; }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        override public string ToString()
        {
            return codigo + " - " + titulo;
        }

    }
}
