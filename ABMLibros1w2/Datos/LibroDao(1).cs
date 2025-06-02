using ABMLibros1w2.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMLibros1w2.Datos
{
    public class LibroDao
    {
        AccesoDatos oBD;
        public LibroDao()
        {
            oBD= new AccesoDatos();
        }
        public List<Autor> RecuperarAutores()
        {
            List<Autor> Lista= new List<Autor>();
            //Traer dela BD
            DataTable tabla= oBD.ConsultarTabla("Autores");
            //Mapear Autores
            foreach (DataRow fila in tabla.Rows)
            {
                Autor oAutor = new Autor();
                oAutor.Codigo = (int)fila["idAutor"];
                oAutor.Nombre = fila["nombre"].ToString();
                Lista.Add(oAutor);
            }
            return Lista;   
        }

        public List<Libro> RecuperarLibros()
        {
            List<Libro> Lista = new List<Libro>();
            //Traer dela BD
            string consultaSQL = "SELECT l.*, a.nombre FROM Libros l, Autores a WHERE l.autor = a.idAutor";
            DataTable tabla = oBD.ConsultarBD(consultaSQL);
            //Mapear Libros
            foreach (DataRow fila in tabla.Rows)
            {
                Libro oLibro=new Libro();
                oLibro.Codigo = (int)fila[0];
                oLibro.Titulo = fila[1].ToString();
                oLibro.Autor = new Autor();
                oLibro.Autor.Codigo= (int)fila[2];
                oLibro.Autor.Nombre= fila[6].ToString();
                oLibro.Formato = (int)fila[3];
                oLibro.Fecha = (DateTime)fila[4];
                oLibro.Precio = (double)fila[5];    
                Lista.Add(oLibro);
            }
            return Lista;
        }
    }
}
