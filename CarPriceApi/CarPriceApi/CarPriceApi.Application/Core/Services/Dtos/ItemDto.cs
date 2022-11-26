using System;
using CarPriceApi.CarPriceApi.Application.Infrastructure.Persistence.Models;

namespace CarPriceApi.CarPriceApi.Application.Core.Dtos
{
    public class ItemDto
    {
        public string NameCar { get; set; }

        public byte[] Image { get; set; }

        public float Price { get; set; }

        public int Category { get; set; }

        public string StoreAddress { get; set; }

        public int Review { get; set; }

        public ItemDto(Item item)
        {
            NameCar = item.NameCar;
            Image = item.Image;
            Price = item.Price;
            Category = item.Category;
            StoreAddress = item.StoreAddress;
            Review = item.Review;
        }
    }
}
