using System.ComponentModel.DataAnnotations;

namespace InterfejsPrototyp.Other
{
    public class CartItems
    {
        [Key]
        public int CartItemId { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;
        public virtual Product? Product { get; set; }
    }
}