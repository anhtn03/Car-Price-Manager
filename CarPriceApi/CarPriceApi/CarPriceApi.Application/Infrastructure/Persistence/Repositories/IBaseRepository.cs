using System.Threading;
using System.Threading.Tasks;
using CarPriceApi.CarPriceApi.Application.Common;

namespace CarPriceApi.CarPriceApi.Application.Infrastructure.Repositories
{
    public interface IBaseRepository<TModel>
    {
        Task CreateAsync(TModel item);
        
        void UpdateAsync(TModel request);

        void DeleteAsync(QueryParams @params);

        Task<QueryResult> GetAllAsync(PaginatorParams<TModel> @params, CancellationToken cancellationToken);


    }
}
