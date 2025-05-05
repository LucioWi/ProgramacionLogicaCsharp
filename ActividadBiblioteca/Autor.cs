using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadBiblioteca
{
    public class Autor : Persona
    {
        private String alias = String.Empty;
        public String Alias
        {
            get { return alias; }
            set { alias = value; }
        }
        public Autor(String NombreYApe, String Nacionalidad, String Sexo, String Direccion, String Alias) : base (NombreYApe, Nacionalidad, Sexo, Direccion) 
        {}
        public override string ToString() //Mostrar
        {
            return "\nAutor:" + "\nNombre y Apellido: " + nombreYApe + "\nNacionalidad: " +
            nacionalidad + "\nSexo: " + sexo + "\nDireccion: " + direccion+"\nAlias: "+ alias;
        }
    }
}