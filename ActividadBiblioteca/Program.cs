using AppBiblioteca;

namespace ActividadBiblioteca
{
    public class Program
    {
        static void Main(string[] args)
        {
            Libro libro1, libro2; // Definir libros
            Revista revista;

            // Crear autor para cada libro
            Autor autor1 = new Autor("J. Kill", "Nacionalidad1", "Mujer", "Direccion1", "Alias1");
            Autor autor2 = new Autor("Steven Thruss", "Nacionalidad2", "Hombre", "Direccion2", "Alias2");

            // Crear libros pasando un objeto de tipo Autor
            libro1 = new Libro("21413-4555-4", autor1, "Intro Prog en C#", 260);
            libro2 = new Libro("345324-552-2", autor2, "C# for dummies", 240);

            revista = new Revista("Titulo", 2555, 500);

            Console.WriteLine("----------------- LIBROS -----------------");
            Console.WriteLine(libro1.ToString()); // Mostrar libros a través de un método
            Console.WriteLine(libro2.ToString());
            Console.WriteLine(revista.ToString());
            Console.WriteLine("------------------------------------------");

            if (libro1.Paginas > libro2.Paginas) // Condicional para averiguar cuál libro tiene más páginas
            {
                Console.WriteLine("\nLibro 1 es el que tiene más páginas\n");
            }
            else
            {
                if (libro2.Paginas > libro1.Paginas)
                {
                    Console.WriteLine("\nLibro 2 es el que tiene más páginas\n");
                }
                else
                {
                    Console.WriteLine("\nAmbos libros tienen la misma cantidad de páginas\n");
                }
            }

            Biblioteca oBiblioteca = new Biblioteca(2); // Definir biblioteca nueva
            oBiblioteca.AgregarLibro(libro1); // Agregar libros a la biblioteca
            oBiblioteca.AgregarLibro(libro2);
            oBiblioteca.AgregarLibro(revista);

            Console.WriteLine(oBiblioteca.MostrarListado()); // Mostrar los libros de la biblioteca

            Console.WriteLine(autor1.ToString());
            Console.WriteLine(autor2.ToString());
        }
    }
}
