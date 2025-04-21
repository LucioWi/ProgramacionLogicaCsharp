using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadBiblioteca
{
    public class Libro
    {
        private String isbn, titulo, autor;
        private int paginas;
        public Libro(String isbn, String titulo, String autor, int paginas)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.autor = autor;
            this.paginas = paginas;
        }
        public String pIsbn
        {
            get { return isbn; }
            set { isbn = value; }
        }
        public String pTitulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public String pAutor
        {
            get { return autor; }
            set { autor = value; }
        }
        public int pPaginas
        {
            get { return paginas; }
            set { paginas = value; }
        }
        public String MostrarLibro()
        {
            return "Libro con ISBN: " + isbn + " creado por: " +
            autor + " tiene " + paginas + " páginas";
        }
    }
}
