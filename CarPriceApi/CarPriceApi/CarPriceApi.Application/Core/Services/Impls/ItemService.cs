using System;
using System.Threading;
using System.Threading.Tasks;
using CarPriceApi.CarPriceApi.Application.Common;
using CarPriceApi.CarPriceApi.Application.Core.Services.Interfaces;
using CarPriceApi.CarPriceApi.Application.Infrastructure.Persistence.Models;
using CarPriceApi.CarPriceApi.Application.Infrastructure.Persistence.Repositories;
using CarPriceApi.CarPriceApi.Application.Infrastructure.Repositories;

namespace CarPriceApi.CarPriceApi.Application.Core.Impls
{
    public class ItemService : IItemServices
    {
        private readonly IItemRepository _itemRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ItemService(IItemRepository itemRepository, IUnitOfWork unitOfWork)
        {
            _itemRepository = itemRepository ?? throw new ArgumentNullException(nameof(itemRepository));
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        public async Task<QueryResult> GetItemAsync(CancellationToken cancellationToken = default)
        {
            var result = await _itemRepository.GetAllAsync(new PaginatorParams<Item>(), cancellationToken);
            return result;
        }
    }
}
    