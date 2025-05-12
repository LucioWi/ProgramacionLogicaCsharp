using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2con4Persona
{
    public class Persona
    {
        private string nombre = string.Empty;
        private int edad = 0;
        private char sexo = '0';
        private double peso= 0 , altura = 0;

        public string Nombre
        {
            get { return nombre; } //propiedades
            set { nombre = value; } //propiedades
        }
        public int Edad
        {
            get { return edad; } 
            set { edad = value; } 
        }
        public char Sexo
        {
            get { return sexo; } 
            set { sexo = value; } 
        }
        public double Peso
        {
            get { return peso; } 
            set { peso = value; } 
        }
        public double Altura
        {
            get { return altura; } 
            set { altura = value; } 
        }

        public double calcularIMC()
        {
            double pesoIdeal = 0;
            double IMCfinal = 0;
            pesoIdeal = peso / (altura * altura);

            if (pesoIdeal < 20)
            {
                IMCfinal = -1;
            }

            if (pesoIdeal >= 20 & pesoIdeal <= 25)
            {
                IMCfinal = 0;
            }

            if (pesoIdeal > 25)
            {
                IMCfinal = 1;
            }

            return IMCfinal;
        }

        public Boolean esMayorDeEdad()
        {
            Boolean esMayorDeEdad;
            if (edad >= 21)
            {
                esMayorDeEdad = true;
            } else
            {
                esMayorDeEdad = false;
            }

            return esMayorDeEdad;
        }
    }
}