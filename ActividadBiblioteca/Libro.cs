using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadBiblioteca
{
    public class Libro
    {
        private String isbn, titulo, autor; //Atributos
        private int paginas;
        public Libro(String isbn, String titulo, String autor, int paginas) //Constructor con parametros
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.autor = autor;
            this.paginas = paginas;
        }
        public String pIsbn
        {
            get { return isbn; } //Propertys
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
        public String MostrarLibro() //Mostrar
        {
            return "Libro con ISBN: " + isbn + "\nCreado por: " +
            autor + "\nTiene " + paginas + " páginas.\n";
        }
    }
}
