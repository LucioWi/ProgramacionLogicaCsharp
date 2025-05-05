using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadBiblioteca
{
    public class Libro : Publicacion
    {
        private String isbn="", autor=""; //Atributos

        public String pIsbn
        {
            get { return isbn; } //Propertys
            set { isbn = value; }
        }
        
        public String pAutor
        {
            get { return autor; }
            set { autor = value; }
        }

        public Libro(String titulo, String pIsbn, String pAutor, int paginas) : base(titulo, paginas)
        { }
        public override string ToString()
        {
            return "Libro titulado:"+Titulo+"\nCon ISBN: " + isbn + "\nCreado por: " +
            autor + "\nTiene " + Paginas + " páginas.\n";
        }
    }
}
