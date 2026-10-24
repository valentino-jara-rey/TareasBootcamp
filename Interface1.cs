using System;
using System.Collections.Generic;
using System.Text;

namespace PrimerTarea
{
    public interface IProductRepository
    {
        void Agregar(Producto producto);
        List<Producto> ObtenerTodos();
        Producto ObtenerPorId(int id);
        List<Producto> BuscarPorCategoria(string categoria);
    }
}
