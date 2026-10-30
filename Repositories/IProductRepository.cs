namespace Bloque2webapi.Repositories;


using System;
using System.Collections.Generic;
using System.Text;
using Bloque2webapi.Models;

public interface IProductRepository
    {
        void Agregar(Producto2 producto);
        List<Producto2> ObtenerTodos();
        Producto2 ObtenerPorId(int id);
        List<Producto2> BuscarPorCategoria(string categoria);
        Producto2 Actualizar(int id);
        IActionResult Eliminar(int id);
    }