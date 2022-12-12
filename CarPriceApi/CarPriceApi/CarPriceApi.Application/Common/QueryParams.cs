using CarPriceApi.CarPriceApi.Application.Infrastructure.Persistence.Models;
using System.Linq.Expressions;

namespace CarPriceApi.CarPriceApi.Application.Common
{
    public class QueryParams
    {
        public Expression<Func<Item, bool>> Filters { get; private set; }

        public QueryParams(Expression<Func<Item, bool>> filters)
        {
           Filters = filters;
        }

        public QueryParams()
        {
            Filters = null;
        }
    
    }
}
