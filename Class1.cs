using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PrimerTarea {

	public class ProductoRepository : IProductRepository
	{
		public List<Producto> Productos { get; private set; }

		public ProductoRepository()
		{
			Productos = new List<Producto>();
		}

		public void Agregar(Producto pProducto)
		{
			this.Productos.Add(pProducto);
		}

		public List<Producto> ObtenerTodos()
		{
			return this.Productos;
		}

		public Producto ObtenerPorId(int pId)
		{
			return this.Productos.FirstOrDefault(p => p.Id == pId);
		}

		public List<Producto> BuscarPorCategoria(string pCategoria)
		{
			return this.Productos.Where(p => p.Category == pCategoria).ToList();
		}


	}
}
