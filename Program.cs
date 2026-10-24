using System;
using PrimerTarea;


namespace PrimerTarea
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IProductRepository repo = new ProductoRepository();

            repo.Agregar(new Producto(1, "Notebook Gamer", 1200000m, "Computación", true));
            repo.Agregar(new Producto(2, "Mouse Óptico", 25000m, "Periféricos", true));
            repo.Agregar(new Producto(3, "Teclado Mecánico", 65000m, "Periféricos", true));


            Console.WriteLine("--- TODOS LOS PRODUCTOS ---");
            var listaCompleta = repo.ObtenerTodos();
            foreach (var p in listaCompleta)
            {
                Console.WriteLine($"ID: {p.Id} | {p.Name} - ${p.Price} ({p.Category})");
            }


            Console.WriteLine("\n--- BUSQUEDA POR CATEGORÍA (Periféricos) ---");
            var perifericos = repo.BuscarPorCategoria("Periféricos");
            foreach (var p in perifericos)
            {
                Console.WriteLine($"- {p.Name}");
            }

            Console.WriteLine("\n--- BUSQUEDA POR ID (1) ---");
            Producto encontrado = repo.ObtenerPorId(1);
            if (encontrado != null)
            {
                Console.WriteLine($"Encontrado: {encontrado.Name}");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }
    }
}
