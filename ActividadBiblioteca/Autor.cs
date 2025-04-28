using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadBiblioteca
{
    public class Autor : Persona
    {
        private String alias = "";
        public String Alias
        {
            get { return alias; }
            set { alias = value; }
        }
        public Autor(String NombreYApe, String Nacionalidad, String Sexo, String Direccion, String Alias) : base (NombreYApe, Nacionalidad, Sexo, Direccion) 
        {}
        public String MostrarAutor() //Mostrar
        {
            return base.MostrarPersona() + "\nAlias: " + alias;
        }
    }
}