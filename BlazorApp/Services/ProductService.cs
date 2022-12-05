using BlazorApp.Models;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace BlazorApp.Services
{
    public class ProductService
    {
        public static readonly List<Product> Products = new List<Product>() {
            new()
            {
                Id = 1,
                Name = "Audi RS3",
                Description = "Engine 2.5L 6 Cyclinder ",
                Price = 50_000


            },
            new()
            {
                Id= 2,
                Name = "Audi RS5",
                Description = "Engine 2.9L V6",
                Price = 70_000
            },
            new() 
            {
                Id= 3,
                Name = "Audi RS6",
                Description = "Engine 4.0L V8",
                Price = 100_000
            }

        };
    }
}