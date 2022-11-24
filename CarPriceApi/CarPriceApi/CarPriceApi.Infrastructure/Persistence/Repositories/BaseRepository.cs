using CarPriceApi.CarPriceApi.Application.Common;
using CarPriceApi.CarPriceApi.Application.Infrastructure.Repositories;

namespace CarPriceApi.CarPriceApi.Infrastructure.Persistence.Repositories
{
    public class BaseRepository<TModel> : IBaseRepository<TModel> where TModel: class
    {
        private readonly MsSqlCarPriceApiDbContext _dbcontext;

        public BaseRepository(MsSqlCarPriceApiDbContext dbContext)
        {
            _dbcontext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }
        public Task CreateAsync(TModel item)
        {
            throw new NotImplementedException();
        }

        public void DeleteAsync(QueryParams<TModel> @params)
        {
            throw new NotImplementedException();
        }

        public Task<QueryResult<TModel>> GetAllAsync(QueryParams<TModel> @params, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public void UpdateAsync(TModel request)
        {
            throw new NotImplementedException();
        }
    }
}
