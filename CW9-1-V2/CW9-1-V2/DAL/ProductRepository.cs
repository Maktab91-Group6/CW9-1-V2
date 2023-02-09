using CW9_1_V2.Models;

namespace CW9_1_V2.DAL
{
    public static class ProductRepository
    {
        public static List<Product> Products { get; set; }
        static ProductRepository()
        {
            Products = new List<Product> { new Product() {Id = 1, Name="Shirt", Color="Blue" } };
        }
    }
}
