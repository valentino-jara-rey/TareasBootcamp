using Bloque2webapi.Dto;
using Bloque2webapi.Models;

namespace Bloque2webapi.Services;
{
    public interface IProductoService
    {
        void Agregar(ProductoDto pProducto);
        List<ProductoDto> ObtenerTodos();
        ProductoDto ObtenerPorId(int id);
        List<ProductoDto> BuscarPorCategoria(string categoria);
        void Eliminar(ProductoDto pProducto);
        void Actualizar(ProductoDto pProducto);
    }
}

