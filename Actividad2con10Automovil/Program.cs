using System;

namespace Actividad2con10Automovil
{
    class Program
    {
        static void Main(string[] args)
        {
            Automovil miAuto = new Automovil(10); // Iniciar con 10 litros
            int opcion = 0;

            do
            {
                Console.WriteLine("\n---------- Menú ----------");
                Console.WriteLine("1. Conducir");
                Console.WriteLine("2. Cargar combustible");
                Console.WriteLine("3. Chequear nivel de combustible");
                Console.WriteLine("4. Salir");
                Console.WriteLine("-----------------------------\n");
                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese los kilómetros a recorrer: ");
                        if (double.TryParse(Console.ReadLine(), out double kms))
                        {
                            miAuto.Conducir(kms);
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida.");
                        }
                        break;

                    case 2:
                        Console.Write("Ingrese los litros de combustible a cargar: ");
                        if (double.TryParse(Console.ReadLine(), out double litros))
                        {
                            miAuto.CargarCombustible(litros);
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida.");
                        }
                        break;

                    case 3:
                        miAuto.ChequearCombustible();
                        break;

                    case 4:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }
            }
            while (opcion != 4);
        }
    }
}