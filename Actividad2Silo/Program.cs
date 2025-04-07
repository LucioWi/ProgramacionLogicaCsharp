using System;

namespace Actividad1con2Silo
{
    class Program
    {
        static void Main(string[] args)
        {
            Silo silo = new Silo();

            Console.Write("Ingrese el radio del silo (en metros): ");
            silo.Radio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la altura del silo (en metros): ");
            silo.Altura = Convert.ToDouble(Console.ReadLine());

            double volumen = silo.CalcularVolumen();
            Console.WriteLine("El volumen máximo del silo es: " + volumen + " m³");
        }
    }
}
