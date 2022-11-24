using CarPriceApi.CarPriceApi.Application.Infrastructure.Persistence.Models;
using CarPriceApi.CarPriceApi.Application.Infrastructure.Repositories;

namespace CarPriceApi.CarPriceApi.Infrastructure.Persistence.Repositories
{
    public class ItemRepository : BaseRepository<Item>, IItemRepository
    {
        public ItemRepository(MsSqlCarPriceApiDbContext msSqlCarPriceApiDbContext)
            : base(msSqlCarPriceApiDbContext)
        {}
    }
}
