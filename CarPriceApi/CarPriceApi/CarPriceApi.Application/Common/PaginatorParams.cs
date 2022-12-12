using System;
using System.Linq.Expressions;

namespace CarPriceApi.CarPriceApi.Application.Common
{
    public class PaginatorParams<TModel>
    { 
        public Expression<Func<TModel, bool>> Filters { get; private set; }

        public int Skip { get; private set; }

        public int Take { get; private set; }

        public string SortField { get; private set; }

        public string SortDirection { get; private set; }
        public PaginatorParams(Expression<Func<TModel, bool>> filters, int skip, int take, string sortfield, string sortdirection )
        {
            Filters = filters;
            Skip = skip;
            Take = take == 0 ? 50 : take;
            SortField = sortfield;
            SortDirection = sortdirection;
        }
    }
}
