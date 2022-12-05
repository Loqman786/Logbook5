using BlazorApp.Models;

namespace BlazorApp.Services
{
    public class CartService
    {
        public List<Product> SelectedItems { get; set; } = new List<Product>();
    }
}
