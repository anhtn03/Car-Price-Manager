using System;
using System.Threading;
using System.Threading.Tasks;
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

        public void DeleteAsync(QueryParams @params)
        {
            throw new NotImplementedException();
        }

        public Task<QueryResult> GetAllAsync(PaginatorParams<TModel> @params, CancellationToken cancellationToken)
        {
            var queryParams = _dbcontext.Set<TModel>().AsQueryable();

            if(@params.Filters != null)
            {

            }
        }

        public void UpdateAsync(TModel request)
        {
            throw new NotImplementedException();
        }
    }
}
