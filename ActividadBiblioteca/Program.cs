namespace ActividadBiblioteca
{
    public class Program
    {
        static void Main(string[] args)
        {
            Libro libro1, libro2; // Definir libros
            Revista revista;

            libro1 = new Libro("Intro Prog en C#", "21413-4555-4", "J. Kill", 260); // Rellenar de datos los libros
            libro2 = new Libro("C# for dummies", "345324-552-2", "Steven Thruss", 240);
            revista = new Revista("Titulo", 2555, 500);

            Autor autor1, autor2;

            autor1 = new Autor("nombre","nacionalidad", "Mujer", "direccion", "alias1");
            autor2 = new Autor("nombre2", "nacionalidad2", "Hombre", "direccion2", "alias2");

            Console.WriteLine("----------------- LIBROS -----------------");
            Console.WriteLine(libro1.ToString()); // Mostrar libros a travez de un metodo
            Console.WriteLine(libro2.ToString());
            Console.WriteLine(revista.ToString());
            Console.WriteLine("------------------------------------------");
            if (libro1.Paginas > libro2.Paginas) // Condicional para averiguar cual libro es mas grande en paginas
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