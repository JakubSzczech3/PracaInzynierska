using System.ComponentModel.DataAnnotations;

namespace InterfejsPrototyp.Other
{


    public class Country
    {
        [Key]
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
