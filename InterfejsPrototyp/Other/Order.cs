namespace InterfejsPrototyp.Other
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; } = "Pending";
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public virtual Product Product { get; set;}
        public virtual Customer Customer { get; set; }

    }
}
