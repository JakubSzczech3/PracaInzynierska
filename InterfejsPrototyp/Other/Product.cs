using System.ComponentModel.DataAnnotations.Schema;

namespace InterfejsPrototyp.Other 
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18,2)")] 
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public int SellerId { get; set; }
        public string Condition { get; set; }
        public string? ImageUrl { get; set; }

        public int StockQuantity { get; set; }

    }
}