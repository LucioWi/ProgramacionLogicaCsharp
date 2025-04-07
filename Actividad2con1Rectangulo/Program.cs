/*
 Persona. Se nos pide modelar una clase Persona con las siguientes
condiciones:
▪ Sus atributos son: nombre, edad, sexo (H hombre, M mujer), peso y altura.
▪ Los métodos que se implementarán son:
o calcularIMC(): calculará si la persona está en su peso ideal (peso en
kg/(altura^2 en m)), si esta fórmula devuelve un valor menor que 20, la
función devuelve un -1, si devuelve un número entre 20 y 25 (incluidos),
significa que está por debajo de su peso ideal la función devuelve un 0
y si devuelve un valor mayor que 25 significa que tiene sobrepeso, la
función devuelve un 1. Se recomienda usar constantes para devolver
estos valores.
o esMayorDeEdad(): indica si es mayor de edad(21 años), devuelve un
booleano. 
 */

using System;

namespace Actividad2con4Persona
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona per1= new Persona();

            Console.Write("Ingrese el nombre: ");
            per1.Nombre = Convert.ToString(Console.ReadLine());

            Console.Write("Ingrese la edad: ");
            per1.Edad = Convert.ToInt16(Console.ReadLine());

            Console.Write("Ingrese el sexo (M = Masculino / F = Femenino): ");
            per1.Sexo = Convert.ToChar(Console.ReadLine());

            Console.Write("Ingrese el peso (En Kg): ");
            per1.Peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la altura (En m / Ejemplo: '1,80'): ");
            per1.Altura = Convert.ToDouble(Console.ReadLine());

            double IMC = per1.calcularIMC();
            Boolean esMayor = per1.esMayorDeEdad();

            Console.WriteLine("-1 = Esta en su indice corporal. / 0 = Esta por debajo de su indice corporal. / 1 = Esta por encima de su indice corporal.");
            Console.WriteLine(" ");
            Console.WriteLine("Su indice de masa corporal es: " + IMC);
            Console.WriteLine("¿Es mayor de edad?: " + esMayor);
        }
    }
}