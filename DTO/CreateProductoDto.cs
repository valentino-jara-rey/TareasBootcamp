namespace Bloque2webapi.DTO;

using System.ComponentModel.DataAnnotations;

public class CreateProductoDto
{
     [Required]
     [StringLength(100, MinimunLength = 3, ErrorMessage = "The name of the product must be at least 3 characters and maximun 100")]
     public string Name { get; private set; }

     [Required]
     [Range(0.01, decimal.MaxValue, ErrorMessage = "the minimun of the price must be at least 1")]
     public decimal Price { get; private set; }

     [Required(ErrorMessage = "There must exist a category")]
     public string Category { get; private set; }

}