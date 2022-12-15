using CarPriceApi.CarPriceApi.Application.Core.Dtos;

namespace CarPriceApi.CarPriceApi.Application.Common
{
    public class QueryResult<TModel>
    {
        public List<TModel> Results { get; set; }

        public QueryResult(List<TModel> result)
        {
            Results = result;
        } 
    }
}
