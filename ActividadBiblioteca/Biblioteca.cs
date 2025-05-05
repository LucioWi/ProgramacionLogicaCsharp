using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadBiblioteca
{
    public class Biblioteca
    {
        private Publicacion[] estanteria;
        private int ultimo; //Atributos
        public Biblioteca(int tamanio)
            {
                estanteria = new Publicacion[tamanio];
                ultimo = 0;
            }
            public void AgregarLibro(Publicacion oPublicacion) //Catalogar cual libro es el ultimo
            {
                if (ultimo < estanteria.Length)
                {
                    estanteria[ultimo] = oPublicacion;
                    ultimo++;
                }
            }
            public String MostrarListado() //Mostrar
            {
                String aux = "|";
                for (int i = 0; i < estanteria.Length; i++)
                    aux += estanteria[i] + "|";
                return aux;
        }
    }
}
