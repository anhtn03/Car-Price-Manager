using CarPriceApi.CarPriceApi.Application.Infrastructure.Persistence.Models;

namespace CarPriceApi.CarPriceApi.Application.Core.Dtos
{
    public class ProductDto
    {
        public long Id { get; set; }

        public string ProductName { get; set; }

        public byte[] Image { get; set; }

        public float Price { get; set; }

        public int Category { get; set; }

        public ProductDto(Product product)
        {
            Id = product.Id;
            ProductName = product.ProductName;
            Image = product.Image;
            Price = product.Price;
            Category = product.Category;
        }
    }
}
