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

        public int InsertarLibro(Libro l)
        {
            int filasAfectadas = 0;

            string query = "INSERT INTO Productos (titulo, autor, formato, fechaPublicacion, precio) " +
                                                  "VALUES(@titulo, @autor, @formato, @fechaPublicacion, @precio)";

            List<Parametro> listaParametros = new List<Parametro>();
            listaParametros.Add(new Parametro("@titulo", l.Titulo));
            listaParametros.Add(new Parametro("@autor", l.Autor.Codigo));
            listaParametros.Add(new Parametro("@formato", l.Formato));
            listaParametros.Add(new Parametro("@fechaPublicacion", l.Fecha));
            listaParametros.Add(new Parametro("@precio", l.Precio));

            filasAfectadas = oBD.ActualizarBD(consultaSQL, listaParametros);

            return filasAfectadas;
        }
    }
}
