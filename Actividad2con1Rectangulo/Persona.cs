using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2con4Persona
{
    public class Persona
    {
        private string nombre = "";
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
            get { return edad; } //propiedades
            set { edad = value; } //propiedades
        }
        public char Sexo
        {
            get { return sexo; } //propiedades
            set { sexo = value; } //propiedades
        }
        public double Peso
        {
            get { return peso; } //propiedades
            set { peso = value; } //propiedades
        }
        public double Altura
        {
            get { return altura; } //propiedades
            set { altura = value; } //propiedades
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