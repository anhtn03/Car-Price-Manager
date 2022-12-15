using CarPriceApi.CarPriceApi.Application.Common;

namespace CarPriceApi.CarPriceApi.Application.Core.Services.Dtos
{
    public class GetProductParams : PaginatorReq
    {
        public int Id { get; set; }
    }
}
