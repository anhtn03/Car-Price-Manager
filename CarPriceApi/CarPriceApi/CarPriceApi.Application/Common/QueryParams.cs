using CarPriceApi.CarPriceApi.Application.Infrastructure.Persistence.Models;
using System.Linq.Expressions;

namespace CarPriceApi.CarPriceApi.Application.Common
{
    public class QueryParams<TModel>
    {
        public Expression<Func<TModel, bool>> Filters { get; private set; }

        public QueryParams(Expression<Func<TModel, bool>> filters)
        {
           Filters = filters;
        }

        public QueryParams()
        {
            Filters = null;
        }
    
    }
}
