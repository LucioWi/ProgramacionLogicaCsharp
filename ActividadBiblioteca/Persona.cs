﻿using System;
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

        public Persona() // Constructor por defecto (necesario para Autor())
        {
            nombreYApe = "";
            nacionalidad = "";
            sexo = "";
            direccion = "";
        }
        public Persona(String NombreYApe, String Nacionalidad, String Sexo, String Direccion)
        {
            nombreYApe = NombreYApe;
            nacionalidad = Nacionalidad;
            sexo = Sexo;
            direccion = Direccion;
        }
        public override string ToString() //Mostrar
        {
            return "\nAutor: " + nombreYApe + "\nNacionalidad: " +
            nacionalidad + "\nSexo: " + sexo + "\nDireccion: " + direccion;
        }
    }
}
