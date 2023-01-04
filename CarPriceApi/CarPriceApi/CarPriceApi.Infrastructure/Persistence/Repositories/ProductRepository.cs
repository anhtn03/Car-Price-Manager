using CarPriceApi.CarPriceApi.Application.Infrastructure.Persistence.Models;
using CarPriceApi.CarPriceApi.Application.Infrastructure.Repositories;

namespace CarPriceApi.CarPriceApi.Infrastructure.Persistence.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IItemRepository
    {
        public ProductRepository(MsSqlCarPriceApiDbContext msSqlCarPriceApiDbContext)
            : base(msSqlCarPriceApiDbContext)
        {}
    }
}
