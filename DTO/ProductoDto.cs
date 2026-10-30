namespace Bloque2webapi.DTO;
{
    public class ProductoDto
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public string Category { get; private set; }
        public bool Active { get; private set; }

    }
}

