using CarPriceApi.CarPriceApi.Application.Core.Dtos;

namespace CarPriceApi.CarPriceApi.Application.Common
{
    public class QueryResult
    {
        public List<ItemDto> Results { get; set; }

        public QueryResult(List<ItemDto> result)
        {
            Results = result;
        } 
    }
}
