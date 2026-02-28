namespace InterfejsPrototyp.Other
{
    public class ProductImage
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int ImageId { get; set; }

        public int ProductId { get; set; }

        public string ImagePath { get; set; } = string.Empty;

        public bool IsMain { get; set; }
        public Product? Product { get; set; }
    }
}
