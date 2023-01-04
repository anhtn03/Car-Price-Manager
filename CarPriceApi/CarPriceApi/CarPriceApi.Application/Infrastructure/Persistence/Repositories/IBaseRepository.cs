using System.Threading;
using System.Threading.Tasks;
using CarPriceApi.CarPriceApi.Application.Common;

namespace CarPriceApi.CarPriceApi.Application.Infrastructure.Repositories
{
    public interface IBaseRepository<TModel>
    {
        Task CreateAsync(TModel @request);
        
        void UpdateAsync(TModel @request);

        void DeleteAsync(QueryParams<TModel> @params);

        Task<QueryResult<TModel>> GetAsync(QueryParams<TModel> @params, CancellationToken cancellationToken);

        Task<PaginatorResult<TModel>> GetAllAsync(PaginatorParams<TModel> paginatorParams, CancellationToken cancellationToken);

    }
}
