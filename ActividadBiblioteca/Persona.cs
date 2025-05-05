using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadBiblioteca
{
    public abstract class Persona
    {
        protected String nombreYApe = "";
        protected String nacionalidad = "";
        protected String sexo = "";
        protected String direccion = "";

        public Persona(String NombreYApe, String Nacionalidad, String Sexo, String Direccion)
        {
            nombreYApe = NombreYApe;
            nacionalidad = Nacionalidad;
            sexo = Sexo;
            direccion = Direccion;
        }
        public override string ToString() //Mostrar
        {
            return "\nAutor:" + "\nNombre y Apellido: " + nombreYApe + "\nNacionalidad: " +
            nacionalidad + "\nSexo: " + sexo + "\nDireccion: " + direccion;
        }
    }
}
