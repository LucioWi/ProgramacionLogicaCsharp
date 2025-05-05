using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadBiblioteca
{
    public abstract class Publicacion
    {
        protected String titulo; //Atributos
        protected int paginas;

        public String Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public int Paginas
        {
            get { return paginas; }
            set { paginas = value; }
        }
        public Publicacion(String titulo, int paginas) //Constructor con parametros
        {
            this.titulo = titulo;
            this.paginas = paginas;
        }

        
    }
}
