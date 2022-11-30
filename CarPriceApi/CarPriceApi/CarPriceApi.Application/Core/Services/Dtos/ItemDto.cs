using CarPriceApi.CarPriceApi.Application.Infrastructure.Persistence.Models;

namespace CarPriceApi.CarPriceApi.Application.Core.Dtos
{
    public class ItemDto
    {
        public long Id { get; set; }

        public string NameCar { get; set; }

        public byte[] Image { get; set; }

        public float Price { get; set; }

        public int Category { get; set; }

        public string StoreAddress { get; set; }

        public int Review { get; set; }

        public ItemDto(Item item)
        {
            Id = item.Id;
            NameCar = item.NameCar;
            Image = item.Image;
            Price = item.Price;
            Category = item.Category;
            StoreAddress = item.StoreAddress;
            Review = item.Review;
        }
    }
}
