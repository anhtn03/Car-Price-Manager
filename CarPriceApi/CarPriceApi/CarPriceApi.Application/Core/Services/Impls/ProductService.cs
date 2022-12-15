using System;
using System.Threading;
using System.Threading.Tasks;
using CarPriceApi.CarPriceApi.Application.Common;
using CarPriceApi.CarPriceApi.Application.Core.Services.Dtos;
using CarPriceApi.CarPriceApi.Application.Core.Services.Interfaces;
using CarPriceApi.CarPriceApi.Application.Infrastructure.Persistence.Models;
using CarPriceApi.CarPriceApi.Application.Infrastructure.Persistence.Repositories;
using CarPriceApi.CarPriceApi.Application.Infrastructure.Repositories;

namespace CarPriceApi.CarPriceApi.Application.Core.Impls
{
    public class ProductService : IProductServices
    {
        private readonly IItemRepository _itemRepository;
        private readonly IUnitOfWork _unitOfWork;
        private const int MaxRequestProduct = 100;
        public ProductService(IItemRepository itemRepository, IUnitOfWork unitOfWork)
        {
            _itemRepository = itemRepository ?? throw new ArgumentNullException(nameof(itemRepository));
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        public async Task<PaginatorResult<Product>> GetProductAsync(GetProductParams req, CancellationToken cancellationToken = default)
        {
            req.Skip = req.Skip < MaxRequestProduct ? req.Skip : MaxRequestProduct;
            
            var result = await _itemRepository.GetAllAsync(new PaginatorParams<Product>(req.Skip, req.Take), cancellationToken);

            return result;
        }
    }
}
    