using CarPriceApi.CarPriceApi.Application.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CarPriceApi.CarPriceApi.Infrastructure.Persistence
{
    public class MsSqlCarPriceApiDbContext : DbContext, IUnitOfWork
    {
        public Task SaveAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
