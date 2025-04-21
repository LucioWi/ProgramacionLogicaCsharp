namespace ActividadBiblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro libro1, libro2;

            libro1 = new Libro("21413-4555-4", "Intro Prog en C#", "J. Kill", 260);
            libro2 = new Libro("345324-552-2", "C# for dummies", "Steven Thruss", 240);
            
            Console.WriteLine(libro1.MostrarLibro());
            Console.WriteLine(libro2.MostrarLibro());
            if (libro1.pPaginas > libro2.pPaginas)
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
            Biblioteca oBiblioteca = new Biblioteca(2);
            
            oBiblioteca.AgregarLibro(libro1);
            oBiblioteca.AgregarLibro(libro2);
            
            Console.WriteLine(oBiblioteca.MostrarListado());                
        }
    }
}