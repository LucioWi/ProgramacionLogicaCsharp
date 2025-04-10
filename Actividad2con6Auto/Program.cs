using System;

namespace Actividad2con6Auto;
class Program
{

/*
 
 */
    static void Main()
    {
        Console.Write("Ingrese la marca del auto: ");
        string marca = Console.ReadLine();

        Console.Write("Ingrese el modelo del auto: ");
        string modelo = Console.ReadLine();

        Console.Write("Ingrese litros de combustible inicial: ");
        double combustibleInicial = double.Parse(Console.ReadLine());

        Auto miAuto = new Auto(marca, modelo, combustibleInicial);

        Console.WriteLine("\n--- Estado inicial del auto ---");
        Console.WriteLine(miAuto.ToString());
        Console.WriteLine("---------------------------------");

        Console.Write("\nIngrese litros de combustible a cargar (Máximo 54): ");
        double litros = double.Parse(Console.ReadLine());

        double derramado = miAuto.CargarCombustible(litros);
        Console.WriteLine(derramado > 0
            ? $"Se derramaron {derramado:F2} litros debido al exceso de combustible ingresado."
            : "Combustible cargado correctamente.");

        Console.Write("\nIngrese los kilómetros a conducir: ");
        double kms = double.Parse(Console.ReadLine());

        string resultado = miAuto.Conducir(kms);
        Console.WriteLine(resultado);

        Console.WriteLine("\n--- Estado final del auto ---");
        Console.WriteLine(miAuto.ToString());
        Console.WriteLine("---------------------------------");
    }
}
