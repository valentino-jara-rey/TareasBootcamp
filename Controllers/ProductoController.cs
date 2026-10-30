using Microsoft.AspNetCore.Mvc;
using Bloque2webapi.Services;
using Bloque2webapi.Dto;

namespace Bloque2webapi.Controllers
{
    [ApiController]
    [Route("api/productos")]
    public class ProductosController : ControllerBase
    {
        private readonly IProductoService _productoService;

        public ProductosController(IProductoService productoService)
        {
            _productoService = productoService;
        }


        [HttpGet]
        public IActionResult ObtenerProductos()
        {
            var productos = _productoService.GetAllProducts();
            return Ok(productos);
        }

        [HttpGet("{id:int}")]
        public IActionResult SearchById(int id)
        {
            try
            {
                var producto = _productoService.GetProductById(id);
                if (producto == null)
                {
                    return NotFound(new { message = $"No se encontró el producto con ID {id}" });
                }
                return Ok(producto);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        
        [HttpPost]
        public IActionResult Create([FromBody] CreateProductoDto createProductoDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var nuevoProducto = _productoService.AddProduct(createProductoDto);

            return CreatedAtAction(
                nameof(SearchById),
                new { id = nuevoProducto.Id },
                nuevoProducto
            );
        }

        [HttpPut("{id:int}")]
        public IActionResult Update(int id, [FromBody] UpdateProductoDto updateProductoDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var actualizado = _productoService.UpdateProduct(id, updateProductoDto);
                if (!actualizado)
                {
                    return NotFound(new { message = $"Producto con ID {id} no encontrado para actualizar." });
                }

                return NoContent();
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var eliminado = _productoService.DeleteProduct(id);
            if (!eliminado)
            {
                return NotFound(new { message = $"No se encontró el producto con ID {id} para eliminar." });
            }

            return NoContent();
        }
    }
}