using Bloque2webapi.Repositories;
using Bloque2webapi.Models;
using Bloque2webapi.Dto;

namespace Bloque2webapi.Services
{
    public class ProductoService : IProductoService
    {
        private readonly IProductoRepository _productoRepository;

        public ProductoService(IProductoRepository pProductoRepo)
        {
            _productoRepository = pProductoRepo;
        }

        public List<ProductoDto> GetAllProducts()
        {
            var products = _productoRepository.ObtenerTodos();

            return products.Select(p => new ProductoDto
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Category = p.Category,
                Active = p.Active,
            }).ToList();
        }

        public ProductoDto GetProductById(int id)
        {
            var product = _productoRepository.ObtenerPorId(id);
            if (product == null) return null;

            return new ProductoDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Category = product.Category,
                Active = product.Active
            };
        }

        public List<ProductoDto> SearchByCategory(string pCategory)
        {
            var products = _productoRepository.ObtenerTodos();

            return products
                .Where(p => p.Category.Equals(pCategory, StringComparison.OrdinalIgnoreCase))
                .Select(p => new ProductoDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    Category = p.Category,
                    Active = p.Active
                })
                .ToList();
        }

        public void AddProduct(ProductoDto pProductoDto)
        {
            var producto = new Producto
            {
                Name = pProductoDto.Name,
                Price = pProductoDto.Price,
                Category = pProductoDto.Category,
                Active = pProductoDto.Active
            }

            _productoRepository.Agregar(producto);
        }

        public void DeleteProduct(int id)
        
            _productoRepository.Eliminar(id);
        }
    }
}