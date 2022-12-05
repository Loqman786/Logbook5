using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace BlazorApp.Models
{
    public class Product
    {

        public int Id { get; set; } = 0;

        [StringLength(60), Required]
        public string Name { get; set; } = string.Empty;

        [StringLength(255), Required]
        public string? Description { get; set; } = null;

        [Range(0, 100.00)]
        public decimal Price { get; set; } = 0;
    }
}
