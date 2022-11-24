using CarPriceApi.CarPriceApi.Application.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CarPriceApi.CarPriceApi.Infrastructure.Persistence
{
    public class MsSqlCarPriceApiDbContext : DbContext, IUnitOfWork
    {
        public MsSqlCarPriceApiDbContext(string connectionString)
            : base(Getoption(connectionString))
        { }

        private static DbContextOptions Getoption(string connectionString)
        {
            if(string.IsNullOrEmpty(connectionString)) 
                throw new ArgumentNullException(nameof(connectionString));

            return new DbContextOptionsBuilder()
                .UseSqlServer(connectionString)
                .Options;
        }

        public Task CommitAsync(CancellationToken cancellationToken)
        {
            return SaveChangesAsync(cancellationToken);
        }

    }
}
