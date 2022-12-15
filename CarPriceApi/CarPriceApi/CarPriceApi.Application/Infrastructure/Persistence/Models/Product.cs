namespace CarPriceApi.CarPriceApi.Application.Infrastructure.Persistence.Models
{
    public class Product
    {
        public long Id { get; set; }

        public string ProductName { get; set; }

        public byte[] Image { get; set; }

        public float Price { get; set; }

        public int Category { get; set; }
    }
}
