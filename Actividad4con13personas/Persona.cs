using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad4con13personas
{
    class Persona
    {
        private string apellido, nombres;
        private int tipoDocumento, documento, estadoCivil, sexo;
        private bool fallecio;

        public Persona()
        {
            apellido = nombres = "";
            tipoDocumento = documento = estadoCivil = sexo = 0;
            fallecio = false;
        }

        public Persona(string apellido, string nombres, int tipoDocumento,
                       int documento, int estadoCivil, int sexo, bool fallecio)
        {
            this.apellido = apellido;
            this.nombres = nombres;
            this.tipoDocumento = tipoDocumento;
            this.documento = documento;
            this.estadoCivil = estadoCivil;
            this.sexo = sexo;
            this.fallecio = fallecio;
        }

        public string Apellido
        {
            set { apellido = value; }
            get { return apellido; }
        }
        public string Nombres
        {
            set { nombres = value; }
            get { return nombres; }
        }
        public int TipoDocumento
        {
            set { tipoDocumento = value; }
            get { return tipoDocumento; }
        }
        public int Documento
        {
            set { documento = value; }
            get { return documento; }
        }
        public int EstadoCivil
        {
            set { estadoCivil = value; }
            get { return estadoCivil; }
        }
        public int Sexo
        {
            set { sexo = value; }
            get { return sexo; }
        }
        public bool Fallecio
        {
            set { fallecio = value; }
            get { return fallecio; }
        }

        override public string ToString()
        {
            return apellido + ", " + nombres;
        }
    }
}
