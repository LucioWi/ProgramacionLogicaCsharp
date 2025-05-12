using System;
using ActividadBiblioteca;

namespace AppBiblioteca
{
    public class Libro : Publicacion
    {
        private string isbn;
        private Autor autor;

        public string PIsbn
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public Autor PAutor
        {
            get { return autor; }
            set { autor = value; }
        }

        public Libro(string pIsbn, Autor pAutor, string titulo, int paginas) : base(titulo, paginas)
        {
            this.isbn = pIsbn;
            this.autor = pAutor;
        }

        public override string ToString()
        {
            return "Libro titulado: " + Titulo +
                   "\nCon ISBN: " + isbn +
                   "\nCreado por: " + autor +
                   "\nTiene " + Paginas + " páginas.\n";
        }
    }
}
