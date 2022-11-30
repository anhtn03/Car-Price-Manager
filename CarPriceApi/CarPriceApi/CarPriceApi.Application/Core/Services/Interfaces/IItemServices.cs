using CarPriceApi.CarPriceApi.Application.Common;

namespace CarPriceApi.CarPriceApi.Application.Core.Services.Interfaces
{
    public interface IItemServices
    {
        Task<QueryResult> GetItemAsync(CancellationToken cancellationToken);
    }
}
