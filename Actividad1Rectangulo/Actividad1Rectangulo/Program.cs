using System;
namespace Actividad1con1Rectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rect = new Rectangulo();
            rect.Ancho = 3;
            rect.Alto = 5;

            // Calcular resultados
            int perimetro = rect.CalcularPer();
            int superficie = rect.CalcularSup();

            // Mostrar resultados
            Console.WriteLine("La base del rectangulo es: " + rect.Ancho);
            Console.WriteLine("La altura del rectangulo es: " + rect.Alto);
            Console.WriteLine("El perímetro del rectangulo es: " + perimetro);
            Console.WriteLine("La superficie del rectangulo es: " + superficie);
        }
    }
}