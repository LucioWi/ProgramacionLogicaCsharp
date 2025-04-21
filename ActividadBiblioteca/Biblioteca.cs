using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadBiblioteca
{
    public class Biblioteca
    {
        private Libro[] estanteria;
        private int ultimo; //Atributos
        public Biblioteca(int tamanio)
            {
                estanteria = new Libro[tamanio];
                ultimo = 0;
            }
            public void AgregarLibro(Libro oLibro) //Catalogar cual libro es el ultimo
            {
                if (ultimo < estanteria.Length)
                {
                    estanteria[ultimo] = oLibro;
                    ultimo++;
                }
            }
            public String MostrarListado() //Mostrar
            {
                String aux = "|";
                for (int i = 0; i < estanteria.Length; i++)
                    aux += estanteria[i].MostrarLibro() + "|";
                return aux;
        }
    }
}
