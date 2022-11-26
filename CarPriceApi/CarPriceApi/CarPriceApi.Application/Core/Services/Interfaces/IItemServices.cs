using System.Threading;
using System.Threading.Tasks;
using CarPriceApi.CarPriceApi.Application.Common;
using CarPriceApi.CarPriceApi.Application.Core.Services.Dtos;
using CarPriceApi.CarPriceApi.Application.Infrastructure.Persistence.Models;

namespace CarPriceApi.CarPriceApi.Application.Core.Services.Interfaces
{
    public interface IItemServices
    {
        Task<PaginatorResult<Item>> GetItemAsync(GetItemResult request, CancellationToken cancellationToken);
    }
}
