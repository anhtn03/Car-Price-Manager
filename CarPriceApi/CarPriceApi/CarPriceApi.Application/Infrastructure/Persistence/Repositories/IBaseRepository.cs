using CarPriceApi.CarPriceApi.Application.Common;

namespace CarPriceApi.CarPriceApi.Application.Infrastructure.Repositories
{
    public interface IBaseRepository<TModel>
    {
        Task CreateAsync(TModel item);
        
        void UpdateAsync(TModel request);

        void DeleteAsync(QueryParams<TModel> @params);

        Task<QueryResult<TModel>> GetAllAsync(QueryParams<TModel> @params, CancellationToken cancellationToken);


    }
}
