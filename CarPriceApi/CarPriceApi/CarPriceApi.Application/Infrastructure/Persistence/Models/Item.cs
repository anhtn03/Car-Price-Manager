namespace CarPriceApi.CarPriceApi.Application.Infrastructure.Persistence.Models
{
    public class Item
    {
        public long Id { get; set; }
        public string NameCar { get; set; }

        public byte[] Image { get; set; }

        public float Price { get; set; }

        public int Category { get; set; }

        public string StoreAddress { get; set; }

        public int Review { get; set; }
    }
}
