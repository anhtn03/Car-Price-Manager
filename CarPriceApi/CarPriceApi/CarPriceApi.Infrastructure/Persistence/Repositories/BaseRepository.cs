using CarPriceApi.CarPriceApi.Application.Common;
using CarPriceApi.CarPriceApi.Application.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CarPriceApi.CarPriceApi.Infrastructure.Persistence.Repositories
{
    public class BaseRepository<TModel> : IBaseRepository<TModel> where TModel: class
    {
        private readonly MsSqlCarPriceApiDbContext _dbcontext;

        public BaseRepository(MsSqlCarPriceApiDbContext dbContext)
        {
            _dbcontext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }
        public Task CreateAsync(TModel @request)
        {
            throw new NotImplementedException();
        }

        public void DeleteAsync(QueryParams<TModel> @params)
        {
            throw new NotImplementedException();
        }

        public async Task<PaginatorResult<TModel>> GetAllAsync(PaginatorParams<TModel> @paginatorParams, CancellationToken cancellationToken)
        {
            var queryParams = _dbcontext.Set<TModel>().AsQueryable();

            if(@paginatorParams.Filters != null)
            {
                queryParams = queryParams.Where(@paginatorParams.Filters).AsNoTracking();
            }
            var data = await queryParams.Skip(@paginatorParams.Skip).Take(@paginatorParams.Take).ToListAsync(cancellationToken);
            var total = await queryParams.CountAsync(cancellationToken);

            return new PaginatorResult<TModel>(data, total);
        }

        public async Task<QueryResult<TModel>> GetAsync(QueryParams<TModel> @params, CancellationToken cancellationToken)
        {
            var queryParams = _dbcontext.Set<TModel>().AsQueryable();

            if(@params.Filters != null)
            {
                queryParams = queryParams.Where(@params.Filters).AsNoTracking();
            }
            var result = await queryParams.ToListAsync(cancellationToken);

            return new QueryResult<TModel>(result);
        }

        public void UpdateAsync(TModel request)
        {
            throw new NotImplementedException();
        }
    }
}
