using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadBiblioteca
{
    public class Revista : Publicacion
    {
        private int codigo; //Atributos

        public int Codigo
        {
            get { return codigo; } //Propertys
            set { codigo = value; }
        }

        public Revista(String titulo, int codigo, int paginas) : base(titulo, paginas)
        { }
        public override string ToString()
        {
            return "Revista titulada:" + Titulo + "\nCon el código: " + Codigo + "\nTiene " + Paginas + " páginas.\n";
        }
    }
}
