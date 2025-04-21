namespace ActividadBiblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro libro1, libro2; // Definir libros

            libro1 = new Libro("21413-4555-4", "Intro Prog en C#", "J. Kill", 260); // Rellenar de datos los libros
            libro2 = new Libro("345324-552-2", "C# for dummies", "Steven Thruss", 240);
            
            Console.WriteLine(libro1.MostrarLibro()); // Mostrar libros a travez de un metodo
            Console.WriteLine(libro2.MostrarLibro());
            if (libro1.pPaginas > libro2.pPaginas) // Condicional para averiguar cual libro es mas grande en paginas
            {
                Console.WriteLine("Libro 1 tiene más páginas");
            }
            else
            {
                if (libro2.pPaginas > libro1.pPaginas)
                {
                    Console.WriteLine("Libro 2 tiene más páginas");
                }
                else
                {
                    Console.WriteLine("Ambos tienen la misma cantidad de páginas");
                }
            }
            Biblioteca oBiblioteca = new Biblioteca(2); // Definir biblioteca nueva
            
            oBiblioteca.AgregarLibro(libro1); // Agregar libros a la biblioteca
            oBiblioteca.AgregarLibro(libro2);
            
            Console.WriteLine(oBiblioteca.MostrarListado()); // Mostrar los libros de la biblioteca
        }
    }
}