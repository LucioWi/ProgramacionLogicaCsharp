using ABMLibros1w2.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMLibros1w2.Negocio
{
    public class LibroServicio
    {
        LibroDao oDao;
        public LibroServicio()
        {
            oDao= new LibroDao();
        }
        public List<Autor> TraerAutores()
        {
            return oDao.RecuperarAutores();
        }

        public List<Libro> TraerLibros()
        {
            return oDao.RecuperarLibros();
        }
    }
}
